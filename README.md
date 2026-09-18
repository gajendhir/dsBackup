<p align="center">
  <img src="dsBackup/Resources/data-protection.png" alt="dsBackup" width="96" />
</p>

<h1 align="center">dsBackup</h1>

<p align="center"><em>Data Spec Auto Backup System</em></p>

A lightweight Windows utility that automates SQL Server database backups —
built especially for SQL Server Express installations, which have no SQL
Server Agent or maintenance plans of their own.

Point it at a server, pick the databases, choose where to keep the backups,
and let it run on a schedule. Each backup is compressed to a zip and
verified before the raw SQL Server backup file is cleaned up — only the
last few raw backups are kept per database, while the zip archives are
retained indefinitely.

![dsBackup main window](docs/images/main-window.png)

## Features

- Connects to any reachable SQL Server instance, with Windows or SQL
  Server authentication
- Multi-select database backup — pick exactly which databases to include
- Automatic zip compression, with integrity verification before cleanup
- Configurable retention: keep the last N raw backups per database
  (zip archives are never pruned)
- Scheduled, unattended backups on a timer (minutes or hours), or run
  manually on demand
- Optional launch on Windows startup
- SQL login password stored encrypted (Windows DPAPI), never in plain text

## Requirements

- Windows
- .NET 10 Desktop Runtime (or the .NET 10 SDK, if building from source)
- A reachable SQL Server instance (SQL Server Express is the primary
  target) whose backup directory is accessible from the machine running
  dsBackup

## Getting started

1. Build from source (see [Programmer Reference](docs/programmerreference.md#build--run)) or install using the packaged installer.
2. Launch dsBackup and connect to your SQL Server instance.
3. Select the databases to back up.
4. Choose where the compressed backups should be stored.
5. Set a backup interval, or click **Backup Now** to run one immediately.

For a full walkthrough written for non-technical users — no coding
knowledge assumed — see the **[User Guide](docs/userguide.md)**.

For architecture, project structure, and build/extension details, see the
**[Programmer Reference](docs/programmerreference.md)**.

## License

MIT — see [LICENSE.txt](LICENSE.txt).

---

<p align="center">
  Software by <a href="https://www.dataspec.info">Data Spec</a>
</p>
