# Archive Completed Lesson

Archive the completed lesson for $ARGUMENTS.

## STEP 1: Gather Info

1. Read `learning/$ARGUMENTS/lesson-plan.md` — Get lesson number and title
2. Read `learning/$ARGUMENTS/lessons/README.md` — See existing lessons

## STEP 2: Archive the Lesson

### Copy Lesson Content
Copy the ENTIRE content of `learning/$ARGUMENTS/lesson-plan.md` to:
`learning/$ARGUMENTS/lessons/lesson-[NN]-[kebab-case-title].md`

Example: `lessons/lesson-03-input-validation-error-handling.md`

### Update Lesson Index
Edit `learning/$ARGUMENTS/lessons/README.md`:

Add a row to the lessons table:
```markdown
| [NN] | [Title] | [link to file] | [YYYY-MM-DD] |
```

## STEP 3: Update Capstone Progress

Read `learning/$ARGUMENTS/goals.md` and update:
- Check off any skills that were covered in this lesson
- If a milestone is now 100% complete, note: "⏳ *Sprint Ready*"

## STEP 4: Check for Milestone Completion

Count skills in the current milestone:
- Completed: [X]
- Total: [Y]

**If X == Y (milestone complete):**
Say to student:
```
🎉 Milestone [N] Complete!

Next session will be a **Capstone Sprint** where you'll build:
[Feature from goals.md]

This is a building session, not a lesson. You code, I review.
```

**If X < Y (milestone not complete):**
Say to student:
```
📚 Lesson archived: lessons/lesson-[NN]-[title].md

Milestone [N] progress: [X]/[Y] skills complete
[Y-X] more lessons until your next Capstone Sprint.
```
