---
description: Automated workflow to ship changes (Assess -> Branch -> Issue -> Commit -> Push -> PR)
---

# Ship It Workflow

This workflow automates the process of shipping code changes.

## Dependencies
- **Skill:** `git-workflow` (Branching, Committing)
- **Skill:** `github-ops` (PRs, Projects)

## Workflow Steps

### 1. Assess Changes
// turbo
Check the status of the repo to understand what will be shipped.
```bash
git status
git diff --stat
```

### 2. Prepare Branch
// turbo
Ensure we are on a fresh branch from main.
**Refer to `git-workflow` skill for details.**
```bash
git fetch origin
git checkout main
git pull origin main
```

**ACTION REQUIRED:**
- **Create Branch:** `git checkout -b <type>/<slug>`

### 3. Commit Changes
**ACTION REQUIRED:**
- **Refer to `git-workflow` skill** for Conventional Commit rules.
- `git add <files>`
- `git commit -m "..."`

### 4. Push to Origin
// turbo
```bash
git push -u origin HEAD
```

### 5. Create PR & Finalize
**ACTION REQUIRED:**
- **Refer to `github-ops` skill** for PR creation and 'Learning Project' assignment.
- `gh pr create ...`
- `gh pr edit --add-project ...`
