# Data Spec Growth Review Notes — dsBackup

Reviewed as part of the Data Spec growth/marketing project (T73), a lighter productization + UX pass, not a full audit.

## Quick reference for future dev work here

- **Security**: `frmBkp.cs` `SaveConfig()` writes the SQL password in plain text to `dsConfig.json` in `CommonAppDataPath`. Worth encrypting just the password field with Windows DPAPI (`ProtectedData.Protect`) before saving — no UX change needed, just a storage fix.
- **Reliability gap**: no verification that the zip archive is valid before the source `.bak` file is deleted (`btnRun_Click`) — worth a basic integrity check first.
- **No failure/completion notification** — this is meant to run unattended/scheduled but only reports status in the UI. A status file or optional email-on-failure would make it trustworthy for real unattended use.
- **Already solid**: full backup → zip → retention (keep last N) pipeline, scheduling, Windows autostart with graceful elevation prompt when needed.

## Productization note

This is close to standalone-shippable as-is — "simple scheduled SQL Server backup-to-zip with retention" is a real, sellable utility for SMBs on SQL Server Express with no backup discipline. Fix the plaintext password storage and add basic failure notification before marketing it to outside clients.
