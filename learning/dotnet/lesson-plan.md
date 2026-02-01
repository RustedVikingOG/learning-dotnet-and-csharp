# .NET Lesson 03: Input Validation & Error Handling

**Estimated Time:** 2-3 hours  
**Prerequisites:** Completed Lesson 2 (route parameters, POST endpoints, CRUD)  
**Milestone:** 1 - REST API Foundation *(final lesson for M1)*

---

## Objectives

- [ ] Add validation to POST endpoints (required fields, data constraints)
- [ ] Return appropriate error responses (400 Bad Request)
- [ ] Implement a PUT endpoint to complete CRUD operations
- [ ] Understand `Results.Created()` with location headers

---

## Key Concepts

1. **Input Validation** - Checking data before processing
2. **Data Annotations** - `[Required]`, `[MinLength]`, `[Range]` attributes
3. **Error Responses** - 400 Bad Request vs 404 Not Found
4. **PUT vs POST** - When to use each for create/update

---

## Exercises

### Exercise 1: Validate Item Creation
Add validation to `POST /items` - name must not be empty.

### Exercise 2: Add PUT Endpoint
Create `PUT /items/{id}` to update an existing item's name.

### Exercise 3: Meaningful Error Messages
Return helpful error messages when validation fails.

---

## Before You Start
    
- Review Lesson 2 concepts (route params, model binding)
- Have your `first-dotnet-webapi` project ready
- Test your existing endpoints still work
