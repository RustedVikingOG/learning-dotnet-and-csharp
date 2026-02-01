---
description: Generate a learning progress report from a teaching session
name: generate-learning-report
---
# Generate Learning Progress Report

You are generating a learning progress report based on a completed teaching session. Use the template at `.github/templates/learning-report.md` as the structure.

## Before Writing: Gather Context

**Required reading before generating the report:**

1. **Previous reports** - Check `reports/[topic]/` for earlier reports. Note patterns, recurring struggles, and growth over time.
2. **Capstone goals** - Read `learning/[topic]/goals.md` to understand which milestone we're working toward.
3. **Current progress** - Review `learning/[topic]/progress.md` for cumulative objectives.
4. **Lesson history** - Scan `learning/[topic]/lessons/README.md` for the learning trajectory.

This context is essential for writing a report that builds on history rather than treating each session in isolation.

## Instructions

Review the conversation history from this teaching session AND the historical context above. Create an accurate, honest, forward-looking assessment.

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

7. **Student Attitude & Engagement**
   - How did the student approach challenges? (frustrated, curious, persistent?)
   - Did they show enthusiasm or resistance to certain topics?
   - Energy level throughout the session
   - Any signs of burnout, boredom, or disengagement?

8. **Historical Patterns** (from previous reports)
   - Is this consistent with past performance?
   - Are recurring struggles being addressed?
   - Is growth evident compared to earlier sessions?

9. **Capstone Alignment**
   - How does this session advance the capstone project?
   - Which milestone skills were practiced?
   - Is the student on track for the current milestone?

10. **Areas for Improvement**
   - What topics need more exploration?
   - What concepts seemed unclear or shaky?

### Critical: The "Shape of the Future" Section

The most important part of the report is the **Path Forward** section. This must:

1. **Synthesize everything** - Combine session performance, historical patterns, capstone goals, and student attitude
2. **Be specific and actionable** - Not vague suggestions, but concrete next steps
3. **Balance challenge with encouragement** - Push growth while maintaining positive momentum
4. **Align with capstone** - Every recommendation should move toward milestone completion
5. **Address the whole student** - If attitude issues exist, suggest how to rekindle engagement

**Example of weak future shaping:**
> "Continue learning about APIs."

**Example of strong future shaping:**
> "Ready for Lesson 03 focusing on input validation—this completes Milestone 1 skill 'Error handling'. Consider starting with a smaller exercise first given last session's frustration with debugging. The POST /items endpoint from Exercise 3 would benefit from validation, making this a natural continuation that shows immediate practical value."

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
