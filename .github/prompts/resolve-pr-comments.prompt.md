```prompt
---
description: Fetch PR review comments, resolve them, and push fixes
name: resolve-pr-comments
---
# Resolve PR Review Comments

Fetch review comments from a PR, address them, commit fixes, and push.

## Overview

```
1. FETCH     → Get PR review comments
2. ANALYZE   → Understand what's requested
3. RESOLVE   → Make the changes
4. COMMIT    → Conventional commit for fixes
5. PUSH      → Update the PR
6. RESPOND   → Mark conversations resolved (optional)
7. REPORT    → Summary of what was addressed
```

---

## Step 1: FETCH - Get Review Comments

### Get PR number (if not known):
```bash
gh pr list --state open --author "@me"
gh pr view --json number,title,url
```

### Fetch all review comments:
```bash
# Get review comments (inline code comments)
gh api repos/{owner}/{repo}/pulls/{pr_number}/comments

# Get review summaries (overall review comments)
gh api repos/{owner}/{repo}/pulls/{pr_number}/reviews

# Simpler: View in terminal
gh pr view {pr_number} --comments
```

### Get specific review details:
```bash
# Get pending/requested changes reviews
gh pr checks {pr_number}
gh pr status
```

### Parse comment structure:
Each comment contains:
- `path` - File that was commented on
- `line` / `original_line` - Line number
- `body` - The comment text
- `user.login` - Who made the comment
- `in_reply_to_id` - If it's a reply in a thread

---

## Step 2: ANALYZE - Understand Requests

Categorize each comment:

| Type | Action Needed |
|------|---------------|
| **Change request** | Code/content modification required |
| **Question** | May need code change or just a reply |
| **Suggestion** | Optional improvement, discuss or implement |
| **Nitpick** | Minor fix (typo, formatting) |
| **Approval note** | No action needed |

**For Copilot reviews specifically:**
- Look for specific file:line references
- Check for suggested code blocks
- Note severity (required vs suggested)

---

## Step 3: RESOLVE - Make Changes

### For each actionable comment:

1. **Read the file** at the specified location
2. **Understand the context** around the comment
3. **Make the fix** following the suggestion
4. **Verify** the change addresses the concern

### Group related fixes:
- Multiple comments on same file → fix together
- Related conceptual changes → fix together
- Unrelated changes → separate commits

---

## Step 4: COMMIT - Conventional Commits

### Commit message format for PR fixes:
```bash
fix(pr): address review feedback

- Fix issue in path/to/file.md (reviewer comment)
- Correct typo in another/file.md
- Update formatting per style guide
```

### Or for single-issue fixes:
```bash
fix(scope): <specific fix description>
```

### Examples:
```bash
git add <files> && git commit -m "fix(pr): address Copilot review feedback

- Add missing error handling in api.cs
- Fix typo in README.md
- Update comment clarity in prompt.md"
```

---

## Step 5: PUSH - Update the PR

```bash
git push
```

The PR will automatically update with new commits.

---

## Step 6: RESPOND - Mark Resolved (Optional)

### Reply to a comment thread:
```bash
gh api repos/{owner}/{repo}/pulls/{pr_number}/comments/{comment_id}/replies \
  --method POST \
  --field body="Fixed in commit abc1234"
```

### Resolve a review thread (via GraphQL):
This requires the thread ID and is more complex. Usually easier to do via UI or let reviewer verify and resolve.

---

## Step 7: REPORT - Summary

```markdown
## ✅ PR Review Comments Addressed

**PR:** #N - [Title](url)

### Comments Resolved

| File | Line | Comment | Resolution |
|------|------|---------|------------|
| `path/file.md` | 42 | "Add error handling" | Added try/catch block |
| `README.md` | 15 | "Typo: recieve" | Fixed to "receive" |

### Commits
- `abc1234` fix(pr): address review feedback

### Remaining
- [ ] Any comments that need discussion
- [ ] Any comments deferred to future PR

### Next Steps
- Wait for re-review
- Or request re-review: `gh pr edit {number} --add-reviewer Copilot`
```

---

## Quick Reference: Complete Example

```bash
# 1. Check current PR
gh pr view --json number,url,reviews

# 2. Get comments
gh pr view 14 --comments

# 3. Or via API for structured data
gh api repos/RustedVikingOG/learning-everything/pulls/14/comments --jq '.[] | {path, line, body, user: .user.login}'

# 4. Make fixes to files
# (edit files as needed)

# 5. Commit fixes
git add -A && git commit -m "fix(pr): address review feedback

- Description of fix 1
- Description of fix 2"

# 6. Push
git push

# 7. Request re-review if needed
gh api repos/RustedVikingOG/learning-everything/pulls/14/requested_reviewers \
  --method POST --field 'reviewers[]=Copilot'
```

---

## Handling Different Review Types

### Copilot Review
- Usually provides specific file:line suggestions
- May include code snippets to apply
- Focus on security, bugs, best practices

### Human Review
- May be more contextual
- Might require discussion before fixing
- Check if it's a blocking request or suggestion

### Requested Changes (Blocking)
- Must be addressed before merge
- Reviewer needs to re-approve after fixes

### Comments (Non-blocking)
- Good to address but not required
- Can discuss or defer with explanation

---

## Useful Commands

```bash
# View PR with all details
gh pr view {number}

# View just comments
gh pr view {number} --comments

# Check PR status (reviews, checks)
gh pr checks {number}
gh pr status

# See review state
gh api repos/{owner}/{repo}/pulls/{number}/reviews --jq '.[] | {user: .user.login, state, body}'

# Re-request review after fixes
gh api repos/{owner}/{repo}/pulls/{number}/requested_reviewers \
  --method POST --field 'reviewers[]=<username>'
```

---

## Edge Cases

### Comment on deleted/moved line
- Find where the code moved to
- Apply fix to new location
- Note in commit message

### Disagreement with suggestion
- Reply explaining reasoning
- Discuss trade-offs
- Document decision

### Comment requires major refactor
- Discuss scope with reviewer
- May split into follow-up PR
- Note as "deferred" in report

### Multiple reviewers with conflicting feedback
- Prioritize: security > correctness > style
- Discuss conflicts, document resolution
- Tag reviewers in discussion

```
