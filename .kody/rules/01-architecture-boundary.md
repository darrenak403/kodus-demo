---
title: "Domain layer must not depend on Infrastructure"
scope: "pull_request"
path: ["src/**/*.cs"]
severity_min: "critical"
languages: ["csharp"]
buckets: ["architecture"]
enabled: true
---

@kody-sync

## Instructions
Review `pr_files_diff` and block changes where domain code imports infrastructure code.
- Any file under `src/**/Domain/**` must not reference namespaces containing `.Infrastructure`.
- Any file under `src/**/Domain/**` must not instantiate classes from `Infrastructure` folders.
- If architecture layering is violated, raise MUST_FIX with exact offending import/usage.

## Examples

### Bad example
```csharp
using Classroom.Api.Infrastructure.Persistence;

namespace Classroom.Api.Domain.Services;

public class GradeService
{
    private readonly SqlGradeRepository _repo = new();
}
```

### Good example
```csharp
using Classroom.Api.Domain.Abstractions;

namespace Classroom.Api.Domain.Services;

public class GradeService
{
    private readonly IGradeRepository _repo;
    public GradeService(IGradeRepository repo) => _repo = repo;
}
```
