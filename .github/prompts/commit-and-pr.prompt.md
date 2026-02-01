```prompt
---
description: Complete workflow to commit changes and create a PR with full metadata
name: commit-and-pr
---
# Full Ship Workflow: Commit and Create PR

This prompt guides the complete workflow from uncommitted changes to a fully-configured PR.

## Overview

```
ASSESS → BRANCH → ISSUE → COMMIT → PUSH → PR → FINALIZE → REPORT
```

---

## Step 1: ASSESS - Understand the Changes

```bash
git status
git diff --stat
```

**Determine:**
- What files changed? (count, types)
- What's the scope? (single feature, multiple, fix, docs)
- What should the branch be named?
- Is there an existing issue this addresses?

---

## Step 2: BRANCH - Create Feature Branch from Main

### If on a different branch with uncommitted changes:
```bash
git fetch origin
git stash
git checkout main
git pull origin main
git checkout -b <branch-type>/<descriptive-name>
git stash pop
```

### If already on main or clean state:
```bash
git fetch origin
git checkout main
git pull origin main
git checkout -b <branch-type>/<descriptive-name>
```

### Branch Naming
| Type | Use When |
|------|----------|
| `feat/` | New features, content, capabilities |
| `fix/` | Bug fixes, corrections |
| `docs/` | Documentation only |
| `chore/` | Config, tooling, maintenance |
| `refactor/` | Restructuring without new features |

**Example:** `feat/capstone-driven-learning`

---

## Step 3: ISSUE - Find or Create Linked Issue

### Search for existing issue:
```bash
gh issue list --label "enhancement" --state open
gh issue list --label "documentation" --state open
```

### If matching issue exists:
- Note the issue number for PR body
- Use "Closes #N" or "Partially addresses #N"

### If no matching issue and changes are substantial:
Create one using `.github/prompts/create-issue.prompt.md`

**For long issue bodies, use a file:**
```bash
# Write body to .tmp/issue-body.md first, then:
gh issue create \
  --title "[meta] <title>" \
  --body-file .tmp/issue-body.md \
  --label "enhancement" \
  --assignee "RustedVikingOG"
```

---

## Step 4: COMMIT - Logical Conventional Commits

### Commit Strategy
1. **Group by logical unit** - Don't commit unrelated files together
2. **Order logically** - Infrastructure → content → docs → config
3. **Never include** - `bin/`, `obj/`, `node_modules/`, `.tmp/`

### Conventional Commit Format
```
<type>(<scope>): <description>

# Examples:
feat(learning): add capstone goals system
feat(prompts): add archive-lesson workflow
feat(agents): enhance teacher with milestone awareness
docs(reports): add historical context section
refactor(dotnet): reorganize folder structure
chore: update gitignore
```

**Rules:**
- Imperative mood: "add" not "added"
- Lowercase, no period
- Max 72 characters
- **No `--author` flag**

### Commit Commands
```bash
# Single file or related files
git add <files> && git commit -m "<type>(<scope>): <description>"

# Multiple related changes with details
git add <files> && git commit -m "<type>(<scope>): <summary>

- Detail 1
- Detail 2"
```

---

## Step 5: PUSH - Push to Origin

```bash
git push -u origin <branch-name>
```

---

## Step 6: PR - Create Pull Request

### Always use body-file for complex PRs:

**Create `.tmp/pr-body.md`:**
```markdown
## Description

<1-2 sentence summary>

Closes #<issue-number>

## Type of Change

- [x] 📚 Learning content (new lessons, exercises, projects)
- [x] 🤖 Agent/Prompt updates (teacher agent, prompts, templates)
<check all that apply>

## Learning Topic

- [x] .NET / C#

## What's Included

### <Category 1>
- Item 1
- Item 2

### <Category 2>
- Item 3

## Checklist

- [x] Commit messages follow conventional commits
- [x] No sensitive information included
- [x] Build artifacts excluded
<add relevant items from .github/pull_request_template.md>

## Notes for Reviewer

<Any context needed>
```

### Create PR:
```bash
gh pr create \
  --title "<type>: <description>" \
  --body-file .tmp/pr-body.md \
  --assignee "RustedVikingOG" \
  --label "<labels>" \
  --base main
```

**Labels to use:**
- `enhancement` - New features, improvements
- `documentation` - Docs changes
- `lesson` - Learning content
- `dotnet` - .NET specific

---

## Step 7: FINALIZE - Add Project and Reviewer

### Add to project:
```bash
gh pr edit <pr-number> --add-project "Learning Project"
```

**If this fails with scope error:**
```bash
gh auth refresh -s project
# Then retry the command
```

### Add Copilot as reviewer (MUST use API):
```bash
gh api repos/RustedVikingOG/learning-everything/pulls/<pr-number>/requested_reviewers \
  --method POST \
  --field 'reviewers[]=Copilot'
```

**Note:** `gh pr edit --add-reviewer` does NOT work for bot accounts.

---

## Step 8: REPORT - Provide Summary

```markdown
## ✅ Ship Complete

| Item | Details |
|------|---------|
| **Branch** | `<branch-name>` |
| **Issue** | #N (created/linked) |
| **PR** | #N - [Title](url) |
| **Commits** | X commits |
| **Assignee** | ✅ RustedVikingOG |
| **Labels** | label1, label2 |
| **Project** | ✅ Learning Project |
| **Reviewer** | ✅ Copilot |

### Commits
1. `<sha>` <message>
2. `<sha>` <message>

### Links
- Issue: https://github.com/RustedVikingOG/learning-everything/issues/N
- PR: https://github.com/RustedVikingOG/learning-everything/pull/N
```

---

## Edge Cases

### Stash has conflicts
```
⚠️ Stash pop failed due to conflicts.
Please resolve manually:
1. Run `git stash show -p` to see stashed changes
2. Resolve conflicts
3. Run `git stash drop` when done
```

### Branch already exists
```bash
git branch -D <branch-name>  # Delete local
git checkout -b <branch-name>
```

### PR body too long for command line
Always use `--body-file .tmp/pr-body.md` for anything beyond trivial PRs.

### Project permission error
```bash
gh auth refresh -s project
# Then retry
```

### Need to verify Copilot was added
```bash
gh api repos/RustedVikingOG/learning-everything/pulls/<pr-number>/requested_reviewers
```

---

## Quick Reference: Complete Example

```bash
# 1. Branch
git fetch origin && git stash
git checkout main && git pull origin main
git checkout -b feat/my-feature
git stash pop

# 2. Commits
git add .github/templates/ && git commit -m "feat(templates): add new template"
git add .github/prompts/ && git commit -m "feat(prompts): add workflow prompt"
git add learning/ && git commit -m "docs(learning): update lesson content"

# 3. Push
git push -u origin feat/my-feature

# 4. Issue (if needed)
gh issue create --title "[meta] Add feature X" --body-file .tmp/issue-body.md --label "enhancement" --assignee "RustedVikingOG"

# 5. PR
gh pr create --title "feat: add feature X" --body-file .tmp/pr-body.md --assignee "RustedVikingOG" --label "enhancement" --base main

# 6. Finalize (assuming PR is #15)
gh pr edit 15 --add-project "Learning Project"
gh api repos/RustedVikingOG/learning-everything/pulls/15/requested_reviewers --method POST --field 'reviewers[]=Copilot'

# 7. Verify
gh pr view 15
```

```
