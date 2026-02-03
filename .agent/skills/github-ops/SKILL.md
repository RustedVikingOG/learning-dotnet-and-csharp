---
description: Comprehensive guide for GitHub operations (Issues, PRs, Reviews)
name: GitHub Ops
---

# GitHub Operations Skill

This skill governs interactions with GitHub via the `gh` CLI.

## 1. Issue Management

**Always search before creating.**
`gh issue list --label "enhancement"`

### creating Issues
```bash
gh issue create \
  --title "<title>" \
  --body "<description>" \
  --label "<label>" \
  --assignee "@me"
```
- Use for: New topics, bugs, feature requests.

### Using Templates (Complex Issues)
For complex issues (e.g., new learning modules), draft the body using a file.
1.  **Draft:** Create `.tmp/issue-body.md`.
2.  **Create:**
    ```bash
    gh issue create \
      --title "<title>" \
      --body-file .tmp/issue-body.md \
      ...
    ```

## 2. Pull Request (PR) Creation

### Requirements
- **Assignee:** `@me` (Repository Owner)
- **Project:** "Learning Project"
- **Labels:** At least one (`enhancement`, `bug`, `documentation`, `lesson`)

### Workflow
1.  **Push Branch:** `git push -u origin <branch>`
2.  **Create PR:**
    ```bash
    gh pr create \
      --title "<type>: <desc>" \
      --body-file .tmp/pr-body.md \
      --assignee "@me" \
      --label "<labels>" \
      --base main
    ```
3.  **Add to Project:**
    ```bash
    gh pr edit <pr-number> --add-project "Learning Project"
    ```

### Using Templates (Complex PRs)
For ALL non-trivial PRs, you MUST use the Pull Request Template.

1.  **Read Template:** Read `.github/pull_request_template.md`.
2.  **Draft Body:** Create `.tmp/pr-body.md` by filling out the template.
    - Check relevant boxes (`[x]`).
    - Fill in "Description", "Type of Change", "Learning Topic".
    - Ensure "Checklist" items are met.
3.  **Use Body File:** Pass `--body-file .tmp/pr-body.md` to `gh pr create`.

## 3. PR Review & Resolution

### Fetching Comments
`gh pr view <number> --comments`

### Resolving
1.  Understand the feedback.
2.  Make changes in code.
3.  **Commit:** `fix(scope): address review feedback`.
4.  **Push:** Updates the existing PR automatically.
5.  **Reply:** `gh pr comment <number> --body "Fixed."`
