---
description: Workflow to start a lesson (Validate -> Explain -> Guide)
---

# Teacher Lesson Start Workflow

Run this when the user says "Let's learn", "Start lesson", or similar.

## Steps

### 1. Validate Context
**ACTION:**
- Read `learning/[topic]/lesson-plan.md`.
- Read `learning/[topic]/goals.md`.
- Ensure they are aligned.

### 2. Check Existing Work
**ACTION:**
- Check for existing project folders/files in `learning/[topic]/capstone-projects/`.
- If found, ask user if they want to resume or start fresh.
- Run `git status` to see if there are uncommitted changes.

### 2. Review Previous Session
**ACTION:**
- Briefly check the last report in `reports/[topic]/`.
- Ask the user if they have questions from last time.

### 3. Explain the Plan
**ACTION:**
- Output the current Lesson Plan objectives.
- Explain **WHY** we are learning this (connect to the Milestone/Capstone).

### 4. Begin Objective 1
**ACTION:**
- Start the first objective.
- Use the **Teacher Persona**: Guide, don't just solve. Ask questions.
