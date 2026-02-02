# 🚀 .NET Capstone Sprint: Chat Rooms & Messages API

**Type:** Capstone Sprint (not a lesson)  
**Estimated Time:** 2-3 hours  
**Prerequisites:** Completed Milestone 1 (Lessons 01-03)  
**Milestone:** 1 - REST API Foundation

---

## 🎯 Sprint Goal

Build an in-memory CRUD API for the WebChat application with:
- **Chat Rooms** - Create, list, get, delete rooms
- **Messages** - Create messages in rooms, list messages by room

This is YOUR build session. You write the code, I guide when needed.

---

## What You're Applying

Skills from Lessons 01-03:
- [x] Minimal API routing (`MapGet`, `MapPost`, `MapPut`, `MapDelete`)
- [x] Route parameters (`/rooms/{id}`, `/rooms/{roomId}/messages`)
- [x] Request body handling (JSON → records)
- [x] Input validation (`string.IsNullOrWhiteSpace`)
- [x] Structured error responses (`ErrorResponse` record)
- [x] HTTP status codes (200, 201, 400, 404)

---

## Suggested Structure

### Chat Room Endpoints
| Method | Route | Description |
|--------|-------|-------------|
| GET | `/rooms` | List all rooms |
| GET | `/rooms/{id}` | Get single room |
| POST | `/rooms` | Create room |
| DELETE | `/rooms/{id}` | Delete room |

### Message Endpoints
| Method | Route | Description |
|--------|-------|-------------|
| GET | `/rooms/{roomId}/messages` | List messages in room |
| POST | `/rooms/{roomId}/messages` | Create message in room |

---

## Data Models to Consider

Think about what properties each entity needs:
- **Room:** What identifies a room? What info does it have?
- **Message:** What identifies a message? Who sent it? When? Which room?

---

## Before You Start

- Have your `first-dotnet-webapi` project ready (or create a new `webchat-api` project)
- Review your existing `/items` endpoints for reference
- Plan your approach: rooms first, then messages?

---

## Success Criteria

- [ ] Can create and list chat rooms
- [ ] Can create messages in a specific room
- [ ] Validation prevents empty room names and empty messages
- [ ] 404 returned when room doesn't exist
- [ ] Clean, consistent error responses

---

## Remember

This is a sprint, not a lesson. I'm here as your pair partner:
- You drive, I navigate
- I'll ask questions, not give answers
- Struggle is part of the process
- When stuck, tell me what you've tried

Let's build! 🏗️
