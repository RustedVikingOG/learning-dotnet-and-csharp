# Learning Everything

A structured learning journey through various technologies, guided by AI-assisted teaching methodology.

## 🎯 Purpose

This repository documents my progress learning various technologies from the ground up. Rather than following traditional courses, I'm using a **guided discovery approach** where an AI teacher helps me learn concepts through exploration, questions, and hands-on exercises.

Each topic has a **capstone project** that lessons build toward, creating purpose-driven learning.

## 📁 Repository Structure

```
.
├── .github/
│   ├── agents/           # Custom Copilot agents (e.g., teacher agent)
│   ├── prompts/          # Prompts for report generation, etc.
│   └── templates/        # Templates for reports, lesson plans
├── learning/
│   └── [topic]/          # Topic-specific learning materials
│       ├── README.md     # Overall progress for this topic
│       ├── progress.md   # Checklist of objectives
│       ├── lesson-plan.md # Current/next lesson plan
│       └── [projects]/   # Hands-on projects and exercises
└── reports/
    └── [topic]/          # Learning session reports
        └── YYYYMMDD-report.md
```

## 🚀 Current Topics

### .NET / C#

| Status | Area | Description |
|--------|------|-------------|
| 🌱 | Web API Basics | Scaffolding, routing, minimal API pattern |
| ⏳ | Route Parameters | Custom endpoints, HTTP methods |
| ⏳ | LINQ | Language Integrated Query in depth |
| ⏳ | Dependency Injection | Builder pattern, services |

**[View .NET Progress →](learning/dotnet/README.md)**

## 🤖 Learning Methodology

This repo uses a custom **Teacher Agent** (`.github/agents/teacher.agent.md`) that:

- **Guides rather than gives** - Leads to solutions through questions and hints
- **Explains the "why"** - Focuses on understanding, not just syntax
- **Encourages exploration** - Points to docs and resources
- **Tracks progress** - Generates honest reports and lesson plans

### Workflow

1. Start a learning session using the teacher agent
2. Work through objectives with guided discovery
3. When complete, the agent generates:
   - Progress report (`reports/[topic]/`)
   - Updated progress tracker (`learning/[topic]/progress.md`)
   - Next lesson plan (`learning/[topic]/lesson-plan.md`)

## 📊 Progress Reports

Session reports provide an honest assessment of understanding, including:

- Objectives completed
- Concepts demonstrated
- Problem-solving approach
- Areas needing more work
- Recommended next steps

**[View Latest .NET Report →](reports/dotnet/20260131-report.md)**

## 🛠️ Environment

| Component | Version |
|-----------|---------|
| .NET SDK | 10.0.102 |
| OS | macOS |
| IDE | VS Code + C# Dev Kit |
| AI | GitHub Copilot (Claude Opus 4.5) |

## 📚 Getting Started

1. Clone this repository
2. Install [.NET SDK](https://dotnet.microsoft.com/download)
3. Open in VS Code with C# Dev Kit extension
4. Start learning with `@teacher` agent in Copilot Chat

## 📝 License

Personal learning repository - feel free to use the structure and templates for your own learning journey.
