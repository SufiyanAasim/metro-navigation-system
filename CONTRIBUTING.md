# Contributing

Thank you for your interest in Metro Navigation System. Contributions are welcome — please read this guide before opening a pull request.

---

## Getting started

1. Fork the repository and clone your fork.
2. Open `src/MetroApp/Metro App.csproj` in Visual Studio, or confirm it builds from the command line: `dotnet build "src/MetroApp/Metro App.csproj" -c Release`
3. Manually exercise the affected screens — there is currently no automated UI test suite (see [tests/README.md](tests/README.md)).
4. Create a branch: `git checkout -b feature/your-feature-name`

## Commit convention

Follow [Conventional Commits](https://www.conventionalcommits.org/):

| Prefix | Use for |
|--------|---------|
| `feat:` | New features |
| `fix:` | Bug fixes |
| `docs:` | Documentation only |
| `refactor:` | Code restructuring without behavior change |
| `chore:` | Build scripts, dependency updates |
| `ci:` | CI/CD configuration |

**Examples:**
```
feat(receipt): add printable ticket flow
fix(stations): correct map marker highlighting
docs(readme): update project structure
```

## Pull request guidelines

- Keep PRs focused — one feature or fix per PR.
- Update `CHANGELOG.md` for any user-facing change, and relevant files under `docs/` if behavior or structure changed.
- Fill in the pull request template fully.
- Reference any related issues with `Closes #n`.

## Code style

- Follow the existing WinForms conventions (designer-generated layout in `*.Designer.cs`, event handlers and logic in the paired `*.cs` file).
- An [.editorconfig](.editorconfig) is provided for basic formatting rules.
- No commented-out code in submitted PRs.

## Reporting bugs

Use the Bug Report issue template under [.github/ISSUE_TEMPLATE](.github/ISSUE_TEMPLATE). Include:
- Windows version and app version.
- Steps to reproduce.
- Expected vs. actual behavior.
- Any relevant error output.

## Security vulnerabilities

Do **not** open a public issue for security vulnerabilities. See [SECURITY.md](SECURITY.md).

---
