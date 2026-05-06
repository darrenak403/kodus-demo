---
title: "No hardcoded secrets or credentials"
scope: "file"
path: ["src/**/*.cs", "src/**/*.json", "appsettings*.json"]
severity_min: "critical"
languages: ["csharp"]
buckets: ["security"]
enabled: true
---

@kody-sync

## Instructions
Flag hardcoded secrets, access tokens, passwords, or connection strings in committed files.
- Detect suspicious literals assigned to keys like `Password`, `Token`, `ApiKey`, `Secret`, `ConnectionString`.
- Allow placeholders only when clearly fake (example: `__SET_IN_ENV__`).
- Raise MUST_FIX with file and exact secret-like string location.

## Examples

### Bad example
```json
{
  "ConnectionStrings": {
    "Default": "Server=db;Database=classroom;User Id=sa;Password=SuperSecret123!"
  }
}
```

### Good example
```json
{
  "ConnectionStrings": {
    "Default": "__SET_IN_ENV__"
  }
}
```
