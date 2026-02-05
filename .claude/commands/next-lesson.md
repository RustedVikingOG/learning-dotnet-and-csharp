# Create Next Lesson Plan

Create the next lesson plan for $ARGUMENTS.

## STEP 1: Gather Context (DO ALL)

Read these files:
1. `learning/$ARGUMENTS/goals.md` — Find current milestone and what skills remain
2. `learning/$ARGUMENTS/progress.md` — What's done, what's next
3. Most recent file in `reports/$ARGUMENTS/` — What should next session cover?
4. `learning/$ARGUMENTS/lessons/README.md` — What lesson number are we on?

## STEP 2: Determine Lesson Content

### Find the Next Lesson Number
Look at `lessons/README.md` to find the highest lesson number. Add 1.
Format: two digits (01, 02, 03, ...)

### Check Milestone Status
From `goals.md`, count skills in current milestone:
- Total skills: [N]
- Completed: [X] 
- Remaining: [N-X]

**If all skills complete:** Next session is a CAPSTONE SPRINT, not a lesson. Use `/sprint` instead.

### Select Objectives
From the remaining skills in the milestone, pick 2-4 that:
1. Build on what was just learned
2. Address any concerns from the last report
3. Are achievable in one session (2-3 hours)

## STEP 3: Write the Lesson Plan

Create/overwrite: `learning/$ARGUMENTS/lesson-plan.md`

Use this EXACT structure (keep under 50 lines):

```markdown
# [Topic] Lesson [NN]: [Descriptive Title]

**Estimated Time:** [X] hours
**Prerequisites:** Lesson [NN-1] complete
**Milestone:** [N] - [Milestone Name]

---

## Objectives

- [ ] [Specific, measurable objective 1]
- [ ] [Specific, measurable objective 2]
- [ ] [Specific, measurable objective 3]

---

## Key Concepts

1. **[Concept]** — [One sentence: what it is and why it matters]
2. **[Concept]** — [One sentence: what it is and why it matters]

---

## Exercises

### Exercise 1: [Name]
[2-3 sentences: what to build and what it demonstrates]

### Exercise 2: [Name]
[2-3 sentences: what to build and what it demonstrates]

### Exercise 3: [Name] (Challenge)
[Optional harder exercise for if student moves fast]

---

## Before You Start

- [ ] Review: [specific thing from last lesson]
- [ ] Have ready: [project/file they'll work in]
```

## STEP 4: Confirm

Say to the student:
```
📝 Next lesson ready: learning/$ARGUMENTS/lesson-plan.md

Lesson [NN]: [Title]
Objectives:
1. [obj 1]
2. [obj 2]

This advances Milestone [N] — [X] skills remaining after this lesson.
```
