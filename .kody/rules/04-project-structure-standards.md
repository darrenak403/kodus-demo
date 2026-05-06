---
title: "Project structure must follow classroom standard"
scope: "pull_request"
path: ["**/*"]
severity_min: "high"
languages: ["csharp"]
buckets: ["style-conventions"]
enabled: true
---

@kody-sync

## Instructions
Enforce repository structure conventions defined by lecturer spec.
- Production code projects must be inside `src/`.
- Test projects must be inside `tests/`.
- New project folders must use PascalCase and avoid spaces/special characters.
- If PR introduces folders/projects outside these conventions, raise MUST_FIX.

## Examples

### Bad example
```text
Added: api-new/Classroom.Api.csproj
Added: tests suite/GradeTests.cs
```

### Good example
```text
Added: src/Classroom.Api/Classroom.Api.csproj
Added: tests/Classroom.Api.Tests/GradeTests.cs
```
