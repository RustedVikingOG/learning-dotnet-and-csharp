# Commit and Pull Request Workflow

When asked to commit changes and create a PR, follow this workflow:

## 1. Create Feature Branch

```bash
git checkout -b <branch-type>/<descriptive-name>
```

Branch types:
- `feat/` - New features or content
- `fix/` - Bug fixes or corrections
- `docs/` - Documentation only
- `chore/` - Maintenance, tooling, config

## 2. Stage and Commit Files

### Commit Strategy
- Group related files together (1-2 files per commit)
- Order commits logically (infrastructure → content → docs)
- Never include build artifacts (`bin/`, `obj/`, `node_modules/`)

### Conventional Commit Format

```
<type>(<scope>): <description>
```

**Types:**
- `feat` - New feature or content
- `fix` - Bug fix or correction
- `docs` - Documentation changes
- `chore` - Maintenance, config, tooling
- `refactor` - Code restructuring
- `test` - Adding or updating tests

**Scope (optional):** Topic or area (e.g., `dotnet`, `csharp`, `agent`)

**Rules:**
- Use imperative mood: "add" not "added" or "adds"
- Lowercase, no period at end
- Max 72 characters
- One-liners only (no body or footer)
- **Do NOT use `--author` flag** - commits should appear as the user's work

### Example Commits

```bash
git add .gitignore && git commit -m "chore: add .gitignore for build artifacts"
git add src/Program.cs && git commit -m "feat(dotnet): add weather endpoint"
git add README.md && git commit -m "docs: update getting started guide"
```

## 3. Push Feature Branch

```bash
git push -u origin <branch-name>
```

## 4. Create Pull Request

Use GitHub CLI to create the PR:

```bash
gh pr create --title "<type>: <description>" --body "<body>"
```

### PR Title
Follow conventional commit format for the title.

### PR Body Template

Craft the body using this structure:

```markdown
## Description

<Brief 1-2 sentence summary of what this PR accomplishes>

## Type of Change

- [x] <Check the appropriate type from the PR template>

## Changes

<Bulleted list of specific changes, grouped logically>

### <Category 1>
- Change 1
- Change 2

### <Category 2>
- Change 3

## Checklist

- [x] Commits follow conventional commit format
- [x] No sensitive information included
- [x] Build artifacts excluded
<Add other relevant checklist items from .github/pull_request_template.md>

## Notes

<Any additional context or areas needing attention>
```

### Example PR Creation

```bash
gh pr create \
  --title "feat: add learning infrastructure and first dotnet lesson" \
  --body "## Description

Adds the complete learning infrastructure including teacher agent, templates, and first .NET Web API lesson.

## Type of Change

- [x] 📚 Learning content (new lessons, exercises, projects)
- [x] 📝 Documentation (README, reports, notes)
- [x] 🤖 Agent/Prompt updates (teacher agent, prompts, templates)

## Changes

### Infrastructure
- Added teacher agent for guided learning
- Added templates for reports, lesson plans, progress tracking
- Added prompt for report generation

### .NET Learning Content
- Scaffolded first Web API project
- Added lesson 1 progress report
- Created lesson 2 plan

## Checklist

- [x] Commits follow conventional commit format
- [x] No sensitive information included
- [x] Build artifacts excluded via .gitignore"
```

## 5. Report to User

After creating the PR, provide a summary:

```markdown
## PR Created ✅

**Branch:** `<branch-name>`
**PR:** <link-to-pr>

### Commits (<count>)
| Commit | Description |
|--------|-------------|
| `abc123` | feat: description |
| `def456` | docs: description |

### Next Steps
- Review the PR at the link above
- Merge when ready
- Delete the feature branch after merge
```

## Important Notes

1. **No `--author` flag** - All commits should be attributed to the repository owner
2. **Check for existing branch** - Use `git branch -a` to verify branch doesn't exist
3. **Verify clean state** - Run `git status` before and after to ensure all intended files are committed
4. **PR template compliance** - Reference `.github/pull_request_template.md` when crafting the body
5. **Link format** - The `gh pr create` command outputs the PR URL; include it in the final report
