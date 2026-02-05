# Ship Command

Complete workflow to commit changes and create a pull request.

Topic: $ARGUMENTS (optional - if provided, limits scope to that topic)

## WORKFLOW: ASSESS → BRANCH → ISSUE → COMMIT → PUSH → PR → FINALIZE → REPORT

## STEP 1: ASSESS - Understand Changes

```bash
git status
git diff --stat
```

**Determine:**
- What files changed? (count, types)
- Scope: single feature, multiple, fix, docs?
- Branch name: `feat/`, `fix/`, `docs/`, `chore/`, `refactor/`
- Is there an existing issue this addresses?

---

## STEP 2: BRANCH - Create Feature Branch

### If on different branch with uncommitted changes:
```bash
git fetch origin
git stash
git checkout main
git pull origin main
git checkout -b <branch-type>/<descriptive-name>
git stash pop
```

### If already on main or clean:
```bash
git fetch origin
git checkout main
git pull origin main
git checkout -b <branch-type>/<descriptive-name>
```

**Branch Examples:** `feat/capstone-sprint-m1`, `docs/update-lesson-03`, `fix/report-template`

---

## STEP 3: ISSUE - Find or Create

Search for existing issue:
```bash
gh issue list --label "enhancement" --state open
gh issue list --state open --search "<keywords>"
```

If no match and changes are substantial, create one using `/issue`.

---

## STEP 4: COMMIT - Logical Conventional Commits

### Format
```
<type>(<scope>): <description>

Examples:
feat(learning): add capstone goals system
feat(prompts): add archive-lesson workflow
docs(reports): add historical context section
fix(dotnet): correct validation logic
```

### Rules
- Imperative mood: "add" not "added"
- Lowercase, no period
- Max 72 characters
- Group by logical unit (templates together, prompts together, etc.)
- Never include: `bin/`, `obj/`, `node_modules/`, `.tmp/`

### Commands
```bash
git add <files> && git commit -m "<type>(<scope>): <description>"
```

---

## STEP 5: PUSH

```bash
git push -u origin <branch-name>
```

---

## STEP 6: PR - Create Pull Request

### Create `.tmp/pr-body.md`:
```markdown
## Description

<1-2 sentence summary>

Closes #<issue-number>

## Type of Change

- [ ] 📚 Learning content (lessons, exercises, projects)
- [ ] 🤖 Agent/Prompt updates (agents, prompts, templates)
- [ ] 📖 Documentation
- [ ] 🐛 Bug fix

## Learning Topic

- [ ] .NET / C#
- [ ] Other: ___

## What's Included

### <Category>
- Item 1
- Item 2

## Checklist

- [ ] Commit messages follow conventional commits
- [ ] No sensitive information included
- [ ] Build artifacts excluded

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

**Labels:** `enhancement`, `documentation`, `lesson`, `dotnet`

---

## STEP 7: FINALIZE - Add Project & Reviewer

```bash
# Add to project
gh pr edit <pr-number> --add-project "Learning Project"

# If scope error:
gh auth refresh -s project

# Add Copilot reviewer (use API)
gh api repos/RustedVikingOG/learning-everything/pulls/<pr-number>/requested_reviewers \
  --method POST \
  --field 'reviewers[]=Copilot'
```

---

## STEP 8: REPORT - Summary

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

### Links
- Issue: <url>
- PR: <url>
```

---

## EDGE CASES

**Stash conflicts:** Show stash with `git stash show -p`, resolve manually

**Branch exists:** `git branch -D <name>` then recreate

**Long PR body:** Always use `--body-file .tmp/pr-body.md`

**Project fails:** Run `gh auth refresh -s project` and retry

---

## QUICK EXAMPLE

```bash
# Branch
git fetch origin && git stash
git checkout main && git pull origin main
git checkout -b feat/my-feature
git stash pop

# Commits
git add .claude/templates/ && git commit -m "feat(templates): add new template"
git add .claude/commands/ && git commit -m "feat(commands): add ship command"

# Push
git push -u origin feat/my-feature

# PR
gh pr create --title "feat: add ship command" --body-file .tmp/pr-body.md --assignee "RustedVikingOG" --label "enhancement" --base main

# Finalize (PR #15)
gh pr edit 15 --add-project "Learning Project"
gh api repos/RustedVikingOG/learning-everything/pulls/15/requested_reviewers --method POST --field 'reviewers[]=Copilot'
```
