# Learning Status

Show current learning status for $ARGUMENTS.

## STEP 1: Read Files

Read these files (do all):
1. `learning/$ARGUMENTS/goals.md`
2. `learning/$ARGUMENTS/progress.md`
3. `learning/$ARGUMENTS/lesson-plan.md`
4. `learning/$ARGUMENTS/README.md`
5. Most recent file in `reports/$ARGUMENTS/`

## STEP 2: Output Status

Say this exactly, filling in the values:

```
📊 Learning Status: $ARGUMENTS

🎯 Current Milestone: [N] - [Name]
   Progress: [X]/[Y] skills ([percentage]%)
   
📋 Next Up: [Lesson or Sprint]
   - [Lesson NN: Title] or [Capstone Sprint: Feature]
   
📈 Recent Session: [date from last report]
   - Completed: [objectives from last report]
   - Watch for: [concerns from last report, or "None"]

🏆 Capstone Project: [Name from goals.md]
   Current State: [What's been built so far]
   Next Feature: [What milestone completion unlocks]

⏱️ Estimated to Milestone Completion: [Y-X] lessons + 1 sprint
```

## STEP 3: Offer Next Steps

```
Ready to continue? Options:
- Start the next lesson: "let's learn"
- See detailed goals: "show goals"
- Review last session: "show last report"
```
