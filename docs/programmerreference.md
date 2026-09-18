# dsBackup Programmer Reference

Technical reference for building, running, and extending dsBackup. For a
non-technical walkthrough of the app itself, see the
[User Guide](userguide.md).

## Overview

dsBackup is a single-form WinForms desktop application that automates SQL
Server database backups. A user connects to a SQL Server instance, selects
databases, chooses a storage folder, and dsBackup backs up each selected
database, compresses it to a zip, verifies the archive, and prunes old
raw backup files by a configurable retention count. It can run manually or
on an internal schedule timer.

## Tech stack

| Layer | Choice |
|---|---|
| UI framework | Windows Forms (`UseWindowsForms=true`) |
| Target framework | `net10.0-windows8.0` (SDK-style `.csproj`) |
| Language | C# |
| SQL access | SQL Server Management Objects (SMO) — `Microsoft.SqlServer.Management.Smo`/`Common`, via the `Microsoft.SqlServer.SqlManagementObjects` NuGet package |
| Config serialization | `Newtonsoft.Json` |
| Config/status storage | Plain JSON files under `Application.CommonAppDataPath` |
| Logging | Custom lightweight file logger (`clsLog`), monthly rollover |
| Installer | Visual Studio Installer project (`.vdproj`), under `AutoBackup/` |

## Build / run

Open `dsBackup.sln` in Visual Studio and run the `dsBackup` project
(`WinExe`), or from the command line:

```
dotnet build dsBackup.sln
dotnet run --project dsBackup/dsBackup.csproj
```

No seed data or external configuration is required for a first run —
dsBackup detects the absence of its config file and walks the user
through the connection, database, and storage panels on first launch.

To exercise the Windows autostart feature during development, run Visual
Studio (or the built executable) as Administrator — the "Load on Windows
Start-up" checkbox is only enabled while elevated, since it writes to
`HKLM\...\Run`.

### Packaging

`AutoBackup/AutoBackup.vdproj` is a Visual Studio Installer project,
built via the Visual Studio Installer Projects extension (not a
`dotnet build`-native target). Its `Debug`/`Release` output lands under
`AutoBackup/`.

## Project structure

```
Program.cs               entry point — WinForms bootstrap
frmBkp.cs / .Designer.cs  UI only: event handlers, control reads/writes, timer
ConfigService.cs          dsConfig.json load/save, password encryption
BackupService.cs          SQL connection + backup/zip/verify/retention pipeline
AutoStartService.cs       Windows Registry autostart (HKLM Run key)
BackupSettings.cs         plain DTO shared between frmBkp and ConfigService
ScheduleHelper.cs         pure schedule/time-format calculations
clsLog.cs                 file-based activity logger
```

There's no dependency injection container or interface layer — each
service class has exactly one consumer (`frmBkp`), constructed directly
in the form's constructor. That's a deliberate choice for an app this
size; introducing abstraction layers for single-consumer services would
add indirection without a corresponding benefit.

```
frmBkp (UI)
  ├── ConfigService     — dsConfig.json I/O, password protection
  ├── BackupService     — SMO connection, backup/zip/verify/retention, dsStatus.json
  ├── AutoStartService  — HKLM Run key autostart, elevation check
  ├── BackupSettings    — DTO shared between frmBkp and ConfigService
  ├── ScheduleHelper    — schedule/time calculations
  └── clsLog            — activity logging, shared across services
```

### `frmBkp`

UI only — no SMO, Registry, JSON, or cryptography code lives here.

- **Panel navigation**: three panels (`pnlSql`, `pnlDatabase`, `pnlPath`)
  toggled by clicking their respective icon (`picSql_Click` /
  `picDB_Click` / `picPath_Click`). It's a single-form wizard, not a
  multi-form navigation stack.
- **Config load/save**: `SaveConfig()` / `LoadConfig()` build or read a
  `BackupSettings` DTO from the form's controls and delegate persistence
  to `ConfigService`. Any control tied to persisted state calls
  `SaveConfig()` from its own `Leave`/`CheckedChanged` handler — there's
  no single central "Save" action; the config file is rewritten in full
  on every relevant field change once the form has finished loading.
- **Backup pipeline UI**: `btnRun_Click` gathers the checked database
  names and calls `BackupService.RunBackup(...)` with `onStatus`/
  `onPercent` callbacks that update the progress label and bar (see
  [Backup pipeline](#backup-pipeline) below).
- **Scheduling**: a one-second WinForms `Timer` (`tmrRef`) counts up to a
  computed `tmrDue` value (via `ScheduleHelper.ToSeconds`), then triggers
  `btnRun_Click` and resets.
- **Autostart UI**: the "Load on Windows Start-up" checkbox is always
  visible but only enabled when running elevated; it reflects the current
  registry state either way. If not elevated, "Run as Administrator"
  relaunches the process with the `runas` verb.

### `ConfigService`

Owns `dsConfig.json` I/O and password protection. `Load()`/`Save()` take
or return a `BackupSettings` DTO. The password field is transparently
protected on save using Windows Data Protection API (DPAPI,
`DataProtectionScope.LocalMachine`) and decrypted on load, falling back to
the raw value if it isn't a valid DPAPI blob yet — this transparently
migrates older plaintext configs on next save, with no version flag or
user-visible change needed.

### `BackupService`

Owns the SMO connection state and the full backup pipeline: `Connect`/
`Disconnect`, `GetDatabaseNames`, `RunBackup(...)`, and the static
`EnumerateAvailableServers()`. Progress is reported via plain
`Action<string>`/`Action<int>` callbacks rather than `IProgress<T>` — the
UI's callback implementations call `Application.DoEvents()` directly to
keep the form responsive during a synchronous backup loop, which an
`IProgress<T>`/`SynchronizationContext` approach would only queue rather
than paint immediately.

#### Backup pipeline

For each selected database, `RunBackup` performs, in order:

1. Build a timestamped name: `{databaseName}_{yyyyMMdd_HHmmss}`.
2. Run a full SMO backup to `{SqlServerBackupDirectory}\{name}.DS`.
3. Compress that file into `{storagePath}\{name}.zip`.
4. Verify the zip: reopen it, confirm the entry's length matches the raw
   file, then fully read the entry — `DeflateStream` validates the
   entry's CRC-32 as it's read, so a corrupt or truncated archive throws
   here even if the file otherwise "opened" fine.
5. Delete raw backup files older than the configured retention count,
   matched by filename prefix — **only** after verification succeeds. A
   failed verification leaves the raw file in place and is recorded as a
   failure rather than deleting anything.
6. Each database runs inside its own try/catch, so one database's failure
   (disconnect, disk full, locked file, etc.) doesn't abort the rest of
   the run — its outcome is recorded independently.
7. After all databases are processed, write `dsStatus.json` with the
   last-run timestamp, an overall success flag, and per-database results.

Compressed zip archives are **never** pruned by dsBackup — only the raw
files in SQL Server's own backup directory are subject to the retention
count. This is a deliberate design choice: the zip is the long-term
retained artifact, and long-term retention/rotation of those archives is
left to the user (an external disk, network share, or manual cleanup).

### `AutoStartService`

Static class wrapping `HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Run`:
`IsElevated()`, `IsRegistered(appName)`, `Register`/`Unregister`. Each
method opens the registry key fresh and closes it rather than holding a
long-lived handle.

### `ScheduleHelper`

Two pure static functions: `SecToHrs(seconds)` for the countdown display,
and `ToSeconds(value, unit)` converting an hours/minutes value into
seconds for the schedule timer.

### `clsLog`

A minimal file-based logger writing to
`%CommonAppData%\dsLOG\Log-yy-MMM.log` (monthly rollover by filename).
Exposes both a simple free-text `Add(message)` and a more structured
`LogEntry(...)` call. Several structured fields (document number, control
ID, transaction ID, etc.) aren't populated by dsBackup — this logger is a
shared pattern used across multiple unrelated desktop tools, so unused
fields exist for cross-tool compatibility rather than being dead code
specific to this app.

## Data flow

1. The UI builds or reads a `BackupSettings` DTO through `ConfigService`
   to/from `dsConfig.json` (plain JSON, password DPAPI-protected).
2. The UI calls `BackupService`, which drives SMO — no direct SMO
   reference exists in `frmBkp`.
3. Backup artifacts flow: SQL Server writes the raw backup file →
   `BackupService` zips it → verifies the zip → deletes the raw file
   (subject to retention, only on successful verification) → the zip
   remains in the user's chosen folder indefinitely.
4. Every significant action also appends to the monthly log file via the
   shared logger, independently of the JSON config.
5. After each run, `BackupService` writes `dsStatus.json` with the
   last-run result.

## File formats and locations

All persisted files live under `Application.CommonAppDataPath` (a
machine-wide `%ProgramData%\...` location, not per-user and not the
project/build directory):

| File | Contents |
|---|---|
| `dsConfig.json` | Server name, credentials (password DPAPI-encrypted), selected databases, storage path, schedule, and retention settings. Machine-wide by design — mirrors the machine-wide autostart registration, so one dsBackup configuration is shared across Windows users on the same machine. |
| `dsStatus.json` | Last-run timestamp, overall success flag, and per-database results. Overwritten each run — no history is retained. |
| `dsLOG\Log-yy-MMM.log` | Plain-text activity log, one file per month. |

## External integrations

- **SQL Server**, via SMO (`Microsoft.SqlServer.Management.Smo`/
  `Common`) — connects, enumerates databases, and runs backups. Supports
  Windows Authentication or SQL Server login/password.
- **Local filesystem** — config/status/log files (above), plus direct
  read/delete access to SQL Server's own backup directory for retention
  cleanup (not done through SMO).
- **Windows Registry** — `HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Run`
  for autostart, requiring an elevated process to write.

No other external APIs, queues, or cloud services are used.

## Assumptions and constraints

- Single-tenant desktop tool: one user, one machine, one SQL Server
  target configured at a time — no multi-server or multi-tenant concept.
- dsBackup must run on, or have direct filesystem access to, the SQL
  Server host itself — it reads and deletes raw backup files directly
  from `Server.BackupDirectory`, not just through a SQL connection.
- Aimed at SQL Server Express deployments that lack SQL Server Agent or
  maintenance plans; it isn't a general-purpose enterprise backup tool.
- The backup loop runs on the UI thread, kept responsive via
  `Application.DoEvents()` rather than an async/background pipeline —
  the simplest option for a single-form app, at the cost of re-entrancy
  risk if another action is triggered mid-run (the UI mitigates this by
  disabling the panels while a backup runs, but nothing lower-level
  guards against it).

## Contributing

Issues and pull requests are welcome. If you're planning a larger change,
consider opening an issue first to discuss the approach — particularly
for anything touching the backup pipeline or credential storage, given
this is a backup tool where correctness and data safety matter more than
usual.
