# Create Learning Issue

Create a GitHub issue for tracking learning objectives.

## Template

Use the template at `.github/templates/learning-issue.md` for structure.

## Issue Creation

```bash
gh issue create --title "<title>" --body "<body>" --label "<labels>"
```

## Title Format

`[<topic>] <brief description>`

- Topic in brackets: `dotnet`, `csharp`, etc.
- Description: imperative mood, concise (under 60 chars)

## Labels

Apply appropriate labels:
- **Always:** `lesson` (unless it's `enhancement` or `documentation`)
- **Topic:** `dotnet`, `csharp`
- **Priority:** `next` if it's the immediate focus

## Body Construction

From user request, extract:

1. **Goal** - What they want to learn (1-2 sentences)
2. **Context** - Why it matters or what it builds on
3. **Acceptance Criteria** - Measurable outcomes (2-4 checkboxes)
4. **Resources** - Optional links or references

## Example

User: "I want to learn how to add route parameters to my API"

```bash
gh issue create \
  --title "[dotnet] Learn route parameters and custom endpoints" \
  --body "## Goal
Add custom endpoints with route parameters to the Web API.

## Context
Builds on Lesson 1 (basic Web API scaffolding). Needed for building real APIs.

## Acceptance Criteria
- [ ] Create GET endpoint with path parameter
- [ ] Create POST endpoint accepting JSON body
- [ ] Understand HTTP method routing (MapGet, MapPost, etc.)

## Resources
- [Lesson 2 Plan](learning/dotnet/lesson-plan.md)" \
  --label "lesson,dotnet,next"
```

## Output

After creating, report:
```
Issue created: #<number>
<issue-url>
```
