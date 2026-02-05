# Create Issue Command

Create or find a GitHub issue for tracking work.

Topic/Title: $ARGUMENTS

## STEP 1: CHECK - Search for Existing Issues

Always search first to avoid duplicates:

```bash
gh issue list --label "enhancement" --state open
gh issue list --label "documentation" --state open
gh issue list --state open --search "<keywords>"
```

If a matching issue exists, use it. Report the issue number and stop.

---

## STEP 2: CREATE - Make New Issue

### Title Format

`[<category>] <brief description>`

| Category | Use For |
|----------|---------|
| `[meta]` | Infrastructure, agents, prompts, templates |
| `[dotnet]` | .NET/C# learning content |
| `[lesson]` | Specific lesson work |
| `[fix]` | Bug fixes, corrections |

**Examples:**
- `[meta] Add capstone-driven learning system`
- `[dotnet] Learn Entity Framework basics`
- `[lesson] Complete lesson 02 - Routes and parameters`

---

## STEP 3: BODY - Create Issue Body

For substantial issues, create `.tmp/issue-body.md`:

```markdown
## Goal

<1-2 sentences: What needs to be accomplished>

## Context

<Why this matters, what it builds on>

## Acceptance Criteria

- [ ] Criterion 1
- [ ] Criterion 2
- [ ] Criterion 3

## Resources

- [Relevant file](path/to/file.md)
- [Documentation](url)

## Related Issues

- Relates to #N
- Builds on #N
```

---

## STEP 4: SUBMIT - Create Issue

### For long bodies (recommended):
```bash
gh issue create \
  --title "<title>" \
  --body-file .tmp/issue-body.md \
  --label "<labels>" \
  --assignee "RustedVikingOG"
```

### For short bodies:
```bash
gh issue create \
  --title "<title>" \
  --body "<body>" \
  --label "<labels>" \
  --assignee "RustedVikingOG"
```

---

## LABELS

| Label | When to Use |
|-------|-------------|
| `enhancement` | New features, improvements, infrastructure |
| `documentation` | Docs-only changes |
| `lesson` | Learning session work |
| `dotnet` | .NET specific |
| `next` | Immediate priority |
| `bug` | Something broken |

**Combine:** `--label "enhancement,dotnet"`

---

## STEP 5: REPORT - Confirm

```markdown
## Issue Created ✅

**Issue:** #<number>
**URL:** <url>
**Labels:** <labels>
**Assignee:** RustedVikingOG
```

---

## EXAMPLES

### Feature Issue

**Title:** `[meta] Add capstone-driven learning system`

**Body:**
```markdown
## Goal

Implement a capstone-driven learning approach where lessons build toward a project.

## Context

Learning without a concrete goal can feel aimless. Defining a capstone project and milestones gives lessons clear purpose.

## Acceptance Criteria

- [ ] Create goals.md template
- [ ] Define milestones for .NET capstone (WebChat)
- [ ] Update teacher with milestone awareness
- [ ] Add capstone sprint command

## Resources

- [Teacher CLAUDE.md](CLAUDE.md)
- [Goals Template](.claude/templates/goals.md)
```

### Lesson Issue

**Title:** `[lesson] Learn route parameters and HTTP methods`

**Body:**
```markdown
## Goal

Complete Lesson 02: Add endpoints with route parameters.

## Context

Builds on Lesson 01 (basic API). Core skill for API development.

## Acceptance Criteria

- [ ] Create GET endpoint with path parameter
- [ ] Create POST endpoint with JSON body
- [ ] Understand HTTP method routing
- [ ] Return different response types

## Resources

- [Lesson 02 Plan](learning/dotnet/lesson-plan.md)
```

---

## QUICK EXAMPLE

```bash
# Search first
gh issue list --state open --search "capstone"

# Create if not found
gh issue create \
  --title "[meta] Add ship command for PR workflow" \
  --body-file .tmp/issue-body.md \
  --label "enhancement" \
  --assignee "RustedVikingOG"
```
