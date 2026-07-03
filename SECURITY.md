# Security Policy

## Supported Versions

Only the latest released version is actively supported with security fixes.

| Version | Supported |
|---------|-----------|
| 1.1.x   | Yes |
| < 1.1   | No  |

## Reporting a Vulnerability

This is a small desktop application with no network services or remote data handling — it reads/writes local files only (trip history under `Metro App Travel History/`). See [docs/authentication.md](docs/authentication.md) and [docs/database.md](docs/database.md) for the app's full trust model. If you find a security issue anyway (e.g. unsafe file handling, path traversal in the receipt/history logger), please report it privately rather than opening a public issue, by emailing:

- **Mohammad Sufiyan Aasim** — [sufiyanaasim@outlook.com](mailto:sufiyanaasim@outlook.com)
- **Fahad Bin Nasir** — [fahadabbasi17025@gmail.com](mailto:fahadabbasi17025@gmail.com)

Please include:
- A description of the issue and its potential impact
- Steps to reproduce
- Affected version

We'll acknowledge reports within a few days.
