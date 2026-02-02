var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");


app.MapGet("/hello/{name}", (string name) =>
{
    var response = $"Hello, {name}!";
    return response;
})
.WithName("GetHello");

app.MapPost("/echo", (MessageRequest messageRequest) =>
{
    var response = new MessageResponse($"You sent: {messageRequest.Message}");
    return response;
});

// In-memory list to store items
// Note: List<T> is not thread-safe. For production, use ConcurrentBag<T> or proper locking.
var items = new List<Item>();
var nextId = 1;

app.MapGet("/items", () =>
{
    return items;
});

app.MapGet("/items/{id}", (int id) =>
{
    var firstItem = items.FirstOrDefault(item => item.Id == id);
    return firstItem is not null ? Results.Ok(firstItem) : Results.NotFound();
});

app.MapPost("/items", (ItemName itemName) =>
{
    if (string.IsNullOrWhiteSpace(itemName.Name))
    {
        return Results.BadRequest(new ErrorResponse("ValidationError", "Name", "Item name cannot be empty."));
    }

    var newItem = new Item(nextId++, itemName.Name);
    items.Add(newItem);
    return Results.Created($"/items/{newItem.Id}", newItem);
});

app.MapPut("/items/{id}", (int id, ItemName itemName) =>
{
    if (string.IsNullOrWhiteSpace(itemName.Name))
    {
        return Results.BadRequest(new ErrorResponse("ValidationError", "Name", "Item name cannot be empty."));
    }
    
    var firstItem = items.FirstOrDefault(item => item.Id == id);
    if (firstItem is not null)
    {
        items.Remove(firstItem);
        var updatedItem = new Item(id, itemName.Name);
        items.Add(updatedItem);
        return Results.Ok(updatedItem);
    }
    return Results.NotFound();
});

app.MapDelete("/items/{id}", (int id) =>
{
    var itemToRemove = items.FirstOrDefault(item => item.Id == id);
    if (itemToRemove is not null)
    {
        items.Remove(itemToRemove);
        return Results.Ok();
    }
    return Results.NotFound();
});

    
app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}

record MessageRequest(string Message);
record MessageResponse(string Message);

record ItemName(string Name);
record Item(int Id, string Name)
{
    public string DisplayName => Name[0].ToString().ToUpper() + Name[1..];
};

record ErrorResponse(string Error, string Field, string Message);