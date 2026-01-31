# .NET Lesson 2: Custom Endpoints & Route Parameters

**Estimated Time:** 2-3 hours  
**Prerequisites:** Completed Lesson 1 (Web API basics, `dotnet run`, endpoint testing)

---

## Objectives

- [ ] Add a custom GET endpoint with a route parameter (`/hello/{name}`)
- [ ] Add a POST endpoint that accepts JSON body data
- [ ] Understand HTTP methods in ASP.NET Core (MapGet, MapPost, MapPut, MapDelete)
- [ ] Return different response types (string, JSON, status codes)

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

### Exercise 2: Echo Endpoint  
Create `POST /echo` that accepts JSON and returns it back.

### Exercise 3: Simple CRUD
Add endpoints to manage a list of items in memory:
- `GET /items` - list all
- `GET /items/{id}` - get one
- `POST /items` - add new
- `DELETE /items/{id}` - remove

---

## Before You Start

- Review `Program.cs` from Lesson 1
- Have `first-dotnet-webapi` project ready
- Keep a terminal open for `dotnet run`
