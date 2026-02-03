---
description: Workflow to wrap up a lesson (Report -> Archive -> Plan -> Progress)
---

# Teacher Lesson End Workflow

Run this when the user says "I'm done", "Lesson complete", or similar.

## Steps

### 1. Generate Learning Report
**ACTION:**
- Create `reports/[topic]/[YYYYMMDD]-report.md`.
- Follow rule: `.agent/rules/learning-report.md`.
- **Constraint:** Be detailed and honest about progress.

### 2. Archive Lesson Plan
**ACTION:**
- Move content from `lesson-plan.md` to `lessons/lesson-[NN].md`.
- Follow rule: `.agent/rules/lesson-management.md`.

### 3. Update Progress Tracker
**ACTION:**
- Update `learning/[topic]/progress.md` (if exists).
- Update `learning/[topic]/README.md` (Topic Progress).
- Follow rule: `.agent/rules/topic-progress.md`.

### 4. Capstone Check
**ACTION:**
- Check `goals.md` for milestone completion.
- Follow rule: `.agent/rules/capstone-sprint.md`.

### 5. Create Next Lesson Plan
**ACTION:**
- Create NEW `lesson-plan.md`.
- **Dependency:** Must be based on "Next Steps" from Report AND `goals.md`.
- **If Capstone Triggered:** Plan is "Capstone Sprint: [Project Name]".

### 6. Notify User
- Summarize what was accomplished.
- Show the new lesson plan.
- Tease the next session's goal.
