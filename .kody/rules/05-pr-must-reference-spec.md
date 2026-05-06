---
title: "PR must reference assignment spec and validation notes"
scope: "pull_request"
path: ["**/*"]
severity_min: "high"
buckets: ["documentation"]
enabled: true
---

@kody-sync

## Instructions
Require PR description to prove implementation matches assignment spec.
- PR description must include:
  - `Spec reference` (link or pasted acceptance criteria),
  - `Implemented scope`,
  - `Validation evidence` (tests run, manual checks, screenshots if UI).
- If any section is missing or empty, raise MUST_FIX.
- Use `pr_description` and `pr_title` to validate completeness.

## Examples

### Bad example
```text
PR description: "Update API"
```

### Good example
```text
Spec reference: Assignment 03 - API grading rules
Implemented scope: Added grading endpoint and validation rules
Validation evidence: dotnet test pass (12/12), tested invalid payload cases
```
