# Authentication

The Metro Navigation System has **no authentication or accounts**. There is no login screen, no password storage, and no concept of "users" — it's a single-user, offline desktop app that anyone with access to the machine can open and use directly from the Welcome screen.

## Why there's no login

- All data (trip history) is local to the machine and tied to whoever is running the executable — there's no multi-user separation to enforce.
- No network calls are made, so there's no remote account or session to authenticate against.
- Adding accounts would mean introducing credential storage, hashing, and a real database (see [database.md](database.md)) for a single-user tool that doesn't need one.

## Security implications

Since there's no auth boundary, the trust boundary is the operating system's own user account and file permissions on the machine running the app. Anyone who can run the executable can view and modify `Metro App Travel History/`. See [SECURITY.md](../SECURITY.md) for the project's security policy and how to report a vulnerability.

## If this ever changes

If a future version adds shared/multi-user features (e.g. syncing trip history across devices, or a companion server), this document is where the authentication model would be described — credential storage, hashing scheme, and session handling — rather than bolted on without a design pass. Until then, treat any code path that assumes a "logged in user" as out of scope for this app.
