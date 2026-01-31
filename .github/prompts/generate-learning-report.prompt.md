---
description: Generate a learning progress report from a teaching session
name: generate-learning-report
---
# Generate Learning Progress Report

You are generating a learning progress report based on a completed teaching session. Use the template at `.github/templates/learning-report.md` as the structure.

## Instructions

Review the conversation history from this teaching session and create an accurate, honest assessment of the student's learning progress.

### Required Information to Extract

1. **Session Details**
   - Student name (if known, otherwise use a placeholder)
   - Estimated effective time spent learning
   - Main topic/focus area

2. **Objectives**
   - What were the stated or implied learning objectives?
   - Which objectives were completed vs. incomplete?

3. **Environment**
   - What tools, SDKs, languages were used?
   - Any setup steps completed?

4. **Concepts Learned**
   - What specific concepts did the student demonstrate understanding of?
   - Include code examples where the student showed comprehension
   - Note any "aha moments" or connections made

5. **Problem-Solving**
   - Did the student encounter errors or issues?
   - How did they approach debugging?
   - Did they recover independently or need heavy guidance?

6. **Prior Knowledge Connections**
   - What existing skills did the student leverage?
   - How did they relate new concepts to familiar ones?

7. **Areas for Improvement**
   - What topics need more exploration?
   - What concepts seemed unclear or shaky?

### Critical: Honest Assessment

**Be truthful about the student's understanding.** The report must accurately reflect their learning:

- ✅ If they demonstrated strong understanding, document it with evidence
- ⚠️ If understanding was partial, note what was grasped and what wasn't  
- ❌ If they struggled with core objectives, flag this clearly in the "Concerns" section

**Do NOT:**
- Inflate progress to make the student feel good
- Gloss over significant misunderstandings
- Skip the concerns section if there are legitimate issues

**DO:**
- Provide constructive feedback
- Note specific examples of both successes and struggles
- Suggest concrete remediation steps for weak areas

### Output

Generate the report in markdown format following the template structure. Save to:
`reports/[topic]/[YYYYMMDD]-report.md`

Where:
- `[topic]` = lowercase topic name (e.g., `dotnet`, `python`, `react`)
- `[YYYYMMDD]` = current date
