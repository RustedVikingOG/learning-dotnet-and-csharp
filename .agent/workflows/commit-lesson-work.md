---
description: Workflow to commit, tag, and ship lesson work
---

# Commit Lesson Work Workflow

Run this to "ship" the code produced during a lesson.

## Dependencies
- **Skill:** `git-workflow`
- **Skill:** `github-ops`

## Steps

### 1. Commit Changes
**ACTION:**
- `git add <files>`
- `git commit` using Conventional Commits.
- **Reference:** `git-workflow` skill.

### 2. Issue Management
**ACTION:**
- Find or Create issue.
- **Reference:** `github-ops` skill.

### 3. Create PR
**ACTION:**
- Push and Create PR.
- **Reference:** `github-ops` skill.
- **Project:** "Learning Project".

### 4. Merge & Cleanup
// turbo
**ACTION:**
- Merge the PR immediately.
```bash
gh pr merge --merge --delete-branch
```

### 5. Next Lesson Prep
// turbo
**ACTION:**
- Return to main and update.
```bash
git checkout main
git pull origin main
```
- **Notify User:** "Ready for next lesson branch."
