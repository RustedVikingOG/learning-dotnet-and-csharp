# .NET Lesson 02: Custom Endpoints & Route Parameters

**Date Completed:** February 1, 2026  
**Estimated Time:** ~2 hours  
**Report:** [View Report](../../../reports/dotnet/20260201-report.md)  
**Milestone:** 1 - REST API Foundation

---

## Objectives ✅

- [x] Add a custom GET endpoint with a route parameter (`/hello/{name}`)
- [x] Add a POST endpoint that accepts JSON body data
- [x] Understand HTTP methods in ASP.NET Core (MapGet, MapPost, MapDelete)
- [x] Return different response types (string, JSON, status codes)

---

## Key Concepts

1. **Route Parameters** - Capturing values from the URL path
2. **Request Body** - Accepting JSON data in POST/PUT requests
3. **HTTP Methods** - When to use GET vs POST vs PUT vs DELETE
4. **Response Types** - `Results.Ok()`, `Results.NotFound()`, `Results.Created()`

---

## Exercises

### Exercise 1: Hello Endpoint
Create `/hello/{name}` that returns `"Hello, {name}!"`.

**Test with:**
```bash
curl http://localhost:5000/hello/World
# Expected: "Hello, World!"
```

### Exercise 2: Echo Endpoint  
Create `POST /echo` that accepts JSON and returns it back.

**Test with:**
```bash
curl -X POST http://localhost:5000/echo \
  -H "Content-Type: application/json" \
  -d '{"message": "test"}'
```

### Exercise 3: Simple CRUD
Add endpoints to manage a list of items in memory:
- `GET /items` - list all
- `GET /items/{id}` - get one
- `POST /items` - add new
- `DELETE /items/{id}` - remove

---

## Key Concepts Covered

1. **Route Parameters** - `{name}` syntax captures URL segments, binds to handler parameters
2. **Model Binding** - Simple types → query string; Complex types (records) → request body
3. **HTTP Methods** - `MapGet`, `MapPost`, `MapDelete` for different operations
4. **Response Types** - `Results.Ok()`, `Results.NotFound()`, string, JSON
5. **HTTP Status Codes** - 200 OK, 404 Not Found

---

## What Was Built

### Hello Endpoint
```csharp
app.MapGet("/hello/{name}", (string name) =>
{
    return $"Hello, {name}!";
});
```

### Echo Endpoint
```csharp
app.MapPost("/echo", (MessageRequest messageRequest) =>
{
    return new MessageResponse($"You sent: {messageRequest.Message}");
});
```

### Full CRUD for Items
- `GET /items` - List all items
- `GET /items/{id}` - Get single item with 404 handling
- `POST /items` - Create item from JSON body
- `DELETE /items/{id}` - Remove item with 404 handling

---

## Bugs Debugged

1. Parameter name mismatch (`{name}` vs `string person`)
2. Simple type looking in query string instead of body
3. Missing `$` for string interpolation
4. Nested object from wrong type assignment

---

## Connections to Prior Knowledge

| .NET Concept | Prior Knowledge |
|--------------|-----------------|
| Route params `{name}` | Vue Router `:id` params |
| `Results.Ok()` | Express `res.json()` |
| `Results.NotFound()` | Express `res.status(404)` |
| In-memory list | Vue component state |

---

## Areas Identified for Next Lesson

- Input validation (what happens with bad/missing data?)
- Error handling (400 Bad Request, custom error messages)
- PUT endpoint for updates
- `Results.Created()` with location headers
