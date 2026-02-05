---
description: Comprehensive guide for Git operations (Branching, Committing, Workflow)
name: Git Workflow
---

# Git Workflow Skill

This skill governs how to manage the git history, branches, and commits.

## 1. Branching Strategy

**Always start from `main` with the latest changes.**

### Workflow
```bash
git fetch origin
git checkout main
git pull origin main
# If you have local changes to bring over:
# git stash -> checkout main -> pull -> checkout -b new-branch -> git stash pop
git checkout -b <type>/<slug>
```

### Naming Convention
Format: `<type>/<slug>` (e.g., `feat/capstone-sprint`)

- `feat/`: New features
- `fix/`: Bug fixes
- `docs/`: Documentation/Learn content
- `chore/`: Maintenance/Config
- `refactor/`: Code restructuring

## 2. Commit Strategy

**Strictly adhere to Conventional Commits.**

### Format
`<type>(<scope>): <description>`

- **Types:** `feat`, `fix`, `docs`, `style`, `refactor`, `test`, `chore`.
- **Scopes:** `agent`, `content`, `infra`, `rules`, `workflows`.
- **Description:** Imperative mood ("add" not "added"), no ending period.

### Logical Grouping
- **Do not** `git add .` indiscriminately.
- Group infrastructure changes separately from content changes.
- Commit *before* running build/test if the changes are structural.

### Examples
```bash
git commit -m "feat(agent): add teacher persona"
git commit -m "docs(lesson-01): fix typos"
```
