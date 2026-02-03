---
description: Automated workflow for completing a learning lesson
---

# Lesson Completion Workflow

This workflow guides the process of wrapping up a learning session, updating progress, and preparing for the next one. Replicates the "Teacher" agent workflow.

## Steps

### 1. Generate Progress Report
**ACTION REQUIRED:**
- Generate a report based on the session.
- Save to `reports/[topic]/[YYYYMMDD]-report.md`.
- Use the prompt: `.github/prompts/generate-learning-report.prompt.md` (if available/convertible) or just generate a comprehensive markdown report.

### 2. Update Progress Tracker
**ACTION REQUIRED:**
- Edit `learning/[topic]/progress.md`.
- Mark completed objectives.
- Add new objectives from the report.

### 3. Create Next Lesson Plan
**ACTION REQUIRED:**
- Create/Update `learning/[topic]/lesson-plan.md`.
- **Constraint:** Max 50 lines.
- Include: Lesson Number, Milestone Ref, Objectives, Concepts, Exercises.

### 4. Update Topic README
**ACTION REQUIRED:**
- Edit `learning/[topic]/README.md`.
- Update "Current Level", "Skills Acquired".
- Add entry to "Lessons Completed" table.

### 5. Archive Completed Lesson
**ACTION REQUIRED:**
- Copy current `lesson-plan.md` content to `lessons/lesson-NN-[title].md`.
- Update `learning/[topic]/lessons/README.md`.

### 6. Capstone Check
**ACTION REQUIRED:**
- Check `learning/[topic]/goals.md`.
- **IF** milestone is 100% complete:
    - Set next lesson as **Capstone Sprint**.
    - Notify user.
- **ELSE**:
    - Continue normal path.
