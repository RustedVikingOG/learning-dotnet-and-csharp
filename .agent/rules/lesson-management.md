---
trigger: model_decision
description: Instructions for managing lesson plans (archive & create)
---

# Lesson Management

## Archiving Completed Lessons

When a lesson is finished and reported on:
1.  **Source:** Read current `learning/[topic]/lesson-plan.md`.
2.  **Target:** Create `learning/[topic]/lessons/lesson-[NN]-[slug].md`.
    - `NN`: Sequential number (01, 02, etc.) derived from the plan or existing lessons.
    - `slug`: Descriptive title.
3.  **Update Index:** Add the new lesson link to `learning/[topic]/lessons/README.md`.

## Creating New Lesson Plans

**Constraint:** The `lesson-plan.md` file is the SINGLE SOURCE OF TRUTH for the *next* immediate session.

### content Requirements
1.  **Alignment:** MUST align with `learning/[topic]/goals.md` (Current Milestone).
2.  **Continuity:** MUST address "Recommended Next Steps" from the previous `learning-report.md`.
3.  **Format:**
    - **Max 50 lines.**
    - Clear objectives (checkboxes).
    - Necessary prerequisites.
    - Estimated time.

### Updating the File
Overwrite `learning/[topic]/lesson-plan.md` with the new plan.
