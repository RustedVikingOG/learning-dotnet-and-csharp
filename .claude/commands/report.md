# Generate Learning Report

Generate a learning progress report for the session that just ended.

Topic: $ARGUMENTS

## STEP 1: Gather Information (DO ALL)

Read these files:
1. `learning/$ARGUMENTS/lesson-plan.md` — What were the objectives?
2. `learning/$ARGUMENTS/goals.md` — What milestone are we on?
3. `learning/$ARGUMENTS/progress.md` — What was already complete?
4. Most recent file in `reports/$ARGUMENTS/` — What happened last time?

## STEP 2: Analyze the Conversation

Go through the conversation and find:

### Objectives Status
For each objective in the lesson plan, determine:
- ✅ COMPLETE — Student wrote working code and explained it
- ⚠️ PARTIAL — Student did it with heavy help or gaps in understanding
- ❌ INCOMPLETE — Not attempted or not working

### Evidence Collection
For each concept covered, find ONE quote or code snippet showing understanding.

### Struggles
List moments where:
- Student said "I don't understand"
- Student needed 3+ hints
- Student's code had repeated errors
- Student seemed frustrated

### Wins
List moments where:
- Student figured something out independently
- Student connected to prior knowledge
- Student asked insightful questions

## STEP 3: Write the Report

Create file: `reports/$ARGUMENTS/[YYYYMMDD]-report.md`

Use this EXACT structure:

```markdown
# [Topic] Learning Progress Report

**Date:** [YYYY-MM-DD]
**Lesson:** [NN] - [Title from lesson-plan.md]
**Milestone:** [N] - [Name] ([X]% complete after this session)
**Effective Time:** [estimate based on conversation length]

---

## Objectives

| Objective | Status | Evidence |
|-----------|--------|----------|
| [name] | ✅/⚠️/❌ | [one sentence] |
| [name] | ✅/⚠️/❌ | [one sentence] |

---

## Concepts Demonstrated

### [Concept 1]
**Understanding:** [Strong/Moderate/Weak]
**Evidence:** [quote or code from conversation]

### [Concept 2]
**Understanding:** [Strong/Moderate/Weak]
**Evidence:** [quote or code from conversation]

---

## Problem-Solving

**Approach:** [How did student handle errors? Methodical? Random? Asked for help immediately?]

**Independence:** [High/Medium/Low] — [one sentence explanation]

---

## Session Dynamics

**Energy:** [High/Medium/Low]
**Engagement:** [Curious/Neutral/Resistant]
**Frustration moments:** [list or "None"]

---

## Concerns

[Leave blank if none. Otherwise list specific gaps:]
- [Concern 1: what was misunderstood]
- [Concern 2: what needs reinforcement]

---

## Strengths

- [Strength 1]
- [Strength 2]

---

## Next Session Should

1. [Most important thing to cover]
2. [Second priority]
3. [If concerns exist: specific remediation needed]

---

## Milestone Progress

**Before this session:** [X]% complete
**After this session:** [Y]% complete
**Skills still needed:** [list from goals.md]
```

## STEP 4: Update Progress Tracker

Edit `learning/$ARGUMENTS/progress.md`:
- Mark completed objectives with `[x]`
- Add any new objectives identified for future lessons

## STEP 5: Confirm

Say to the student:
```
📊 Report saved: reports/$ARGUMENTS/[date]-report.md

Summary:
- Objectives: [X] complete, [Y] partial, [Z] incomplete
- Key strength: [one thing]
- Watch for next time: [one thing]
```
