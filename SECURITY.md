# Security Policy

## Supported versions

| Version | Supported |
|---------|-----------|
| 1.1.x   | Yes       |
| 1.0.x   | No        |

## Reporting a vulnerability

**Do not open a public GitHub issue for security vulnerabilities.**

Report vulnerabilities privately by emailing:

**sufiyanaasim@outlook.com**

Include in your report:
- A clear description of the vulnerability.
- Steps to reproduce or a proof-of-concept.
- The potential impact.
- Your suggested fix, if any.

You will receive a response within 7 days. If the vulnerability is confirmed, a patch will be released as a priority and you will be credited in the release notes unless you prefer to remain anonymous.

## Security model

- The application has no accounts, no authentication, and no network layer — see [docs/Architecture.md](docs/Architecture.md) for the full trust model.
- All persisted data is local, flat-text trip history under `Metro App Travel History/` — see [docs/Database.md](docs/Database.md).
- No credentials or secrets are ever written to disk.
- The application stores all data locally. No data is transmitted over a network in the current release.
