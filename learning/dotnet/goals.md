# .NET Capstone Project: WebChat

**Target Completion:** When Milestone 6 is done  
**Current Milestone:** 1 - REST API Foundation  
**Current Progress:** 🟡 In Progress

---

## Project Overview

A real-time chat application that demonstrates full-stack .NET development. By completion, this project will feature:

- RESTful API with authentication
- Real-time messaging via SignalR
- Persistent data storage
- Background job processing
- Production-ready deployment

---

## Milestones

### Milestone 1: REST API Foundation ✅
*Building blocks of any .NET web application*

**Goal:** A working API that can manage users and messages via HTTP endpoints.

| Skill | Status | Lesson |
|-------|--------|--------|
| Project scaffolding | ✅ | 01 |
| Minimal API routing | ✅ | 01 |
| Route parameters | ✅ | 02 |
| HTTP methods (GET/POST/DELETE) | ✅ | 02 |
| HTTP methods (PUT) | ✅ | 03 |
| Request/response JSON | ✅ | 02 |
| Input validation | ✅ | 03 |
| Error handling | ✅ | 03 |

**Capstone Feature:** Basic CRUD API for chat rooms and messages (in-memory). ⏳ *Sprint Ready*

---

### Milestone 2: Data Persistence ⬜
*Storing data properly*

**Goal:** Chat data persists to a database and survives restarts.

| Skill | Status | Lesson |
|-------|--------|--------|
| Entity Framework Core basics | ⬜ | - |
| Code-first migrations | ⬜ | - |
| Repository pattern | ⬜ | - |
| SQLite/PostgreSQL setup | ⬜ | - |
| Relationships (1:many, many:many) | ⬜ | - |
| LINQ queries | ⬜ | - |

**Capstone Feature:** Persistent storage for users, rooms, and messages.

---

### Milestone 3: Authentication & Users ⬜
*Securing the application*

**Goal:** Users can register, log in, and access protected resources.

| Skill | Status | Lesson |
|-------|--------|--------|
| ASP.NET Identity basics | ⬜ | - |
| JWT token authentication | ⬜ | - |
| Authorization policies | ⬜ | - |
| Password hashing | ⬜ | - |
| Middleware pipeline | ⬜ | - |

**Capstone Feature:** User registration, login, and protected chat endpoints.

---

### Milestone 4: Real-time Communication ⬜
*Making it a chat app*

**Goal:** Messages appear instantly without page refresh.

| Skill | Status | Lesson |
|-------|--------|--------|
| SignalR basics | ⬜ | - |
| Hub methods | ⬜ | - |
| Groups (chat rooms) | ⬜ | - |
| Connection management | ⬜ | - |
| Client integration | ⬜ | - |

**Capstone Feature:** Real-time message delivery to connected users.

---

### Milestone 5: Background Processing ⬜
*Handling work asynchronously*

**Goal:** System can process tasks outside of HTTP requests.

| Skill | Status | Lesson |
|-------|--------|--------|
| Hosted services | ⬜ | - |
| Background queues | ⬜ | - |
| Scheduled tasks | ⬜ | - |
| Message cleanup jobs | ⬜ | - |

**Capstone Feature:** Automatic cleanup of old messages, notification processing.

---

### Milestone 6: Production Ready ⬜
*Deploying with confidence*

**Goal:** Application runs reliably in production.

| Skill | Status | Lesson |
|-------|--------|--------|
| Docker containerization | ⬜ | - |
| Health checks | ⬜ | - |
| Structured logging | ⬜ | - |
| Configuration management | ⬜ | - |
| CI/CD basics | ⬜ | - |
| Cloud deployment | ⬜ | - |

**Capstone Feature:** Deployed, monitored, production WebChat application.

---

## Progress Summary

```
Milestone 1: ██████████ 100% ✅
Milestone 2: ░░░░░░░░░░   0%
Milestone 3: ░░░░░░░░░░   0%
Milestone 4: ░░░░░░░░░░   0%
Milestone 5: ░░░░░░░░░░   0%
Milestone 6: ░░░░░░░░░░   0%
─────────────────────────
Overall:     ██░░░░░░░░  17%
```

---

## Why WebChat?

This project was chosen because it naturally exercises the full .NET stack:

- **REST APIs** - CRUD operations for users, rooms, messages
- **Data Access** - Relationships, queries, persistence
- **Security** - Authentication is mandatory for chat
- **Real-time** - SignalR is the defining feature
- **Scale Concerns** - Background jobs, connection management
- **DevOps** - Stateful app requires proper deployment

Each milestone builds on the previous, creating a complete application.

---

## Learning Cadence: Milestone-Gated Capstone Sprints

Learning follows a **theory → practice** rhythm. After completing each milestone's lessons, a **Capstone Sprint** applies those skills to the actual WebChat project.

### How It Works

```
┌─────────────────┐     ┌─────────────────┐     ┌─────────────────┐
│  LESSONS 01-03  │ ──► │  MILESTONE 1    │ ──► │ CAPSTONE SPRINT │
│  (Learn skills) │     │  (Skills done)  │     │ (Build feature) │
└─────────────────┘     └─────────────────┘     └─────────────────┘
                                                        │
        ┌───────────────────────────────────────────────┘
        ▼
┌─────────────────┐     ┌─────────────────┐     ┌─────────────────┐
│  LESSONS 04-06  │ ──► │  MILESTONE 2    │ ──► │ CAPSTONE SPRINT │
│  (Learn skills) │     │  (Skills done)  │     │ (Build feature) │
└─────────────────┘     └─────────────────┘     └─────────────────┘
        ...and so on
```

### Capstone Sprint Schedule

| Milestone | Lessons | Sprint Goal | Est. Sessions |
|-----------|---------|-------------|---------------|
| M1: REST API Foundation | 01-03 | In-memory CRUD API for rooms/messages | 1-2 |
| M2: Data Persistence | 04-06 | Persist to SQLite database | 1-2 |
| M3: Authentication | 07-09 | User registration + JWT auth | 2 |
| M4: Real-time | 10-12 | SignalR messaging | 2 |
| M5: Background Processing | 13-15 | Notification jobs, cleanup | 1-2 |
| M6: Production Ready | 16-18 | Docker + deployment | 1-2 |

### During Capstone Sprints

- Teacher shifts from "teaching" to "code review/pairing" mode
- Student writes the code; teacher asks guiding questions
- Focus is on applying learned skills, not introducing new concepts
- Use `.github/prompts/capstone-sprint.prompt.md` for sprint sessions

### Current Status

- **Current Milestone:** 1 - REST API Foundation ✅ COMPLETE
- **Lessons Completed:** 01, 02, 03
- **Next Session:** 🚀 CAPSTONE SPRINT - Build chat rooms and messages API!
