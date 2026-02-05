---
trigger: model_decision
description: Instructions for generating a learning report
---

# Learning Report Generation

When a lesson or learning session is complete, generate a learning report.

## Report Path
Save the report to: `reports/[topic]/[YYYYMMDD]-report.md`
(e.g., `reports/csharp/20240320-report.md`)

## Report Content
Use the template at `.github/templates/learning-report.md` if available.

The report MUST include:
1.  **Summary:** Brief overview of what was covered.
2.  **Objectives Status:** Which objectives from `lesson-plan.md` were met?
3.  **Key Concepts:** List of concepts mastered vs. those needing review.
4.  **Areas for Improvement:** Honest assessment of struggles.
5.  **Recommended Next Steps:** What should the next lesson cover?

> [!IMPORTANT]
> Be honest. If the user struggled, document it. This informs the next lesson plan.
