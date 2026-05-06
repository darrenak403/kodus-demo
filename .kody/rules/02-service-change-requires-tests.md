---
title: "Service changes must include corresponding tests"
scope: "pull_request"
path: ["src/**/*.cs", "tests/**/*.cs"]
severity_min: "critical"
languages: ["csharp"]
buckets: ["testing"]
enabled: true
---

@kody-sync

## Instructions
When service or business logic files are changed, require matching test updates in the same PR.
- If files under `src/**/Services/**`, `src/**/Application/**`, or `src/**/Domain/**` change, verify related test files are added or updated under `tests/**`.
- If no matching test change exists, raise MUST_FIX.
- Mention which source files changed and which expected test area is missing.

## Examples

### Bad example
```text
Changed: src/Classroom.Api/Services/GradeCalculator.cs
No files changed under tests/
```

### Good example
```text
Changed: src/Classroom.Api/Services/GradeCalculator.cs
Changed: tests/Classroom.Api.Tests/Services/GradeCalculatorTests.cs
```
