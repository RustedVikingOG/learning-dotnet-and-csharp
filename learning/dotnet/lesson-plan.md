# 🗄️ Lesson 04: Entity Framework Core Basics

**Type:** Lesson (Theory + Practice)
**Estimated Time:** 1.5 hours
**Milestone:** 2 - Data Persistence

---

## 🎯 Objectives

1.  **Understand ORMs:** What is Entity Framework Core and why do we use it?
2.  **Install EF Core:** Add packages to the project.
3.  **Create a DbContext:** The bridge between code and data.
4.  **Entities vs DTOs:** Refactoring our `record` models into proper Entities.
5.  **In-Memory Database:** Using EF Core's in-memory provider (for testing/learning before SQL).

---

## 📚 Theory: The Persistence Layer

Currently, `var rooms = new List<Room>();` dies when the app stops.
To save data, we need a database. But writing raw SQL (`SELECT * FROM Rooms`) is tedious and error-prone.

**Enter EF Core (ORM):**
- **ORM:** Object-Relational Mapper.
- Maps C# Objects (`Room`) <--> Database Rows (Table `Rooms`).
- We write C#, EF writes the SQL.

### Key Components
1.  **Entity:** A class representing a table (e.g., `class Room { Id, Name }`).
2.  **DbContext:** Represents a session with the database. Manages saving/retrieving entities.
3.  **DbSet<T>:** Represents a table inside the DbContext.

---

## 🏗️ Exercises

### 1. Project Setup (Refactor WebChat)
We will continue working on your **WebChatApi**.

**Step A: Install Packages**
```bash
dotnet add package Microsoft.EntityFrameworkCore.InMemory
```

### 2. Define Entities
Refactor `Room` and `Message` from `record` (immutable) to `class` (mutable, easier for EF).

```csharp
public class Room
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
```

### 3. The AppDbContext
Create `Data/AppDbContext.cs`.

```csharp
class AppDbContext : DbContext 
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
    public DbSet<Room> Rooms => Set<Room>();
    public DbSet<Message> Messages => Set<Message>();
}
```

### 4. Dependency Injection
Wire it up in `Program.cs`.

```csharp
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseInMemoryDatabase("WebChat"));
```

### 5. Refactor Endpoints
Replace `List<Room>` with `db.Rooms`.

---

## 🧪 Success Criteria

- [ ] `Microsoft.EntityFrameworkCore.InMemory` package installed
- [ ] `AppDbContext` created and registered in DI
- [ ] Endpoints refactored to use `db.Rooms.ToList()` and `db.SaveChanges()`
- [ ] App behaves exactly as before, but using EF Core syntax

---

## 🧠 Check for Understanding

- Why do we need a `DbContext`?
- What is difference between `List.Add()` and `db.Rooms.Add()`? (Hint: `SaveChanges`)
