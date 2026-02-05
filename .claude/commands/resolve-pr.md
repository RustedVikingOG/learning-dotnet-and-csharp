# Resolve PR Comments Command

Fetch PR review comments, resolve them, commit fixes, and push.

PR Number: $ARGUMENTS (if not provided, use current PR)

## WORKFLOW: FETCH → ANALYZE → RESOLVE → COMMIT → PUSH → REPORT

---

## STEP 1: FETCH - Get Review Comments

### Get PR number if not provided:
```bash
gh pr list --state open --author "@me"
gh pr view --json number,title,url
```

### View all comments:
```bash
gh pr view {pr_number} --comments
```

### Or get structured data:
```bash
# Inline code comments
gh api repos/RustedVikingOG/learning-everything/pulls/{pr_number}/comments

# Review summaries
gh api repos/RustedVikingOG/learning-everything/pulls/{pr_number}/reviews
```

### Parse comment structure:
- `path` - File commented on
- `line` - Line number
- `body` - Comment text
- `user.login` - Who made it

---

## STEP 2: ANALYZE - Categorize Comments

| Type | Action |
|------|--------|
| **Change request** | Code/content modification required |
| **Question** | May need change or just reply |
| **Suggestion** | Optional improvement |
| **Nitpick** | Minor fix (typo, formatting) |
| **Approval note** | No action |

**For Copilot reviews:**
- Look for file:line references
- Check for suggested code blocks
- Note severity (required vs suggested)

---

## STEP 3: RESOLVE - Make Changes

For each actionable comment:
1. Read the file at specified location
2. Understand context
3. Make the fix
4. Verify it addresses the concern

**Group related fixes:**
- Same file → fix together
- Related concepts → fix together
- Unrelated → separate commits

---

## STEP 4: COMMIT - Fixes

### Format:
```bash
fix(pr): address review feedback

- Fix issue in path/to/file.md
- Correct typo in another/file.md
- Update formatting per style guide
```

### Or for single fix:
```bash
fix(scope): <specific fix description>
```

### Example:
```bash
git add <files> && git commit -m "fix(pr): address Copilot review

- Add missing error handling in api.cs
- Fix typo in README.md
- Update comment clarity in prompt.md"
```

---

## STEP 5: PUSH - Update PR

```bash
git push
```

PR automatically updates with new commits.

---

## STEP 6: REPORT - Summary

```markdown
## ✅ PR Review Comments Addressed

**PR:** #N - [Title](url)

### Comments Resolved

| File | Line | Comment | Resolution |
|------|------|---------|------------|
| `path/file.md` | 42 | "Add error handling" | Added try/catch |
| `README.md` | 15 | "Typo: recieve" | Fixed to "receive" |

### Commits
- `abc1234` fix(pr): address review feedback

### Remaining
- [ ] Comments needing discussion
- [ ] Comments deferred to future PR

### Next Steps
- Wait for re-review or request: `gh api repos/RustedVikingOG/learning-everything/pulls/{number}/requested_reviewers --method POST --field 'reviewers[]=Copilot'`
```

---

## QUICK EXAMPLE

```bash
# Get comments
gh pr view 14 --comments

# Or structured
gh api repos/RustedVikingOG/learning-everything/pulls/14/comments --jq '.[] | {path, line, body}'

# Make fixes (edit files)

# Commit
git add -A && git commit -m "fix(pr): address review feedback

- Description of fix 1
- Description of fix 2"

# Push
git push

# Re-request review if needed
gh api repos/RustedVikingOG/learning-everything/pulls/14/requested_reviewers \
  --method POST --field 'reviewers[]=Copilot'
```

---

## HANDLING DIFFERENT REVIEW TYPES

### Copilot Review
- Specific file:line suggestions
- May include code snippets
- Focus on security, bugs, best practices

### Requested Changes (Blocking)
- Must address before merge
- Reviewer needs to re-approve

### Comments (Non-blocking)
- Good to address but not required
- Can discuss or defer

---

## EDGE CASES

**Comment on deleted/moved line:** Find new location, apply fix, note in commit

**Disagreement:** Reply with reasoning, discuss trade-offs, document decision

**Major refactor needed:** Discuss scope, may split to follow-up PR

**Conflicting feedback:** Prioritize security > correctness > style, discuss, document
