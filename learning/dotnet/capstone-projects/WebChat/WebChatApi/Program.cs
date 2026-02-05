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

string generateId() {
    return Guid.NewGuid().ToString();
}

var rooms = new List<Room>();
var messages = new List<Message>();

// Rooms
app.MapGet("/rooms", () =>
{
    if (rooms.Count == 0) {
        return Results.NotFound();
    }
    return Results.Ok(rooms);
})
.WithName("GetRooms");


app.MapGet("/rooms/{id}", (string id) =>
{
    if (string.IsNullOrWhiteSpace(id))
    {
        return Results.BadRequest();
    }
    if (rooms.All(r => r.Id != id))
    {
        return Results.NotFound();
    }
    return Results.Ok(rooms.FirstOrDefault(r => r.Id == id));
})
.WithName("GetRoom");

app.MapPost("/rooms", (CreateRoomRequest request) =>
{
    if (string.IsNullOrWhiteSpace(request.Name))
    {
        return Results.BadRequest();
    }
    var room = new Room(generateId(), request.Name, DateTime.Now);
    rooms.Add(room);
    return Results.Ok(room);    
})
.WithName("CreateRoom");

app.MapDelete("/rooms/{id}", (string id) =>
{
    if (string.IsNullOrWhiteSpace(id))
    {
        return Results.BadRequest();
    }
    var roomToDelete = rooms.FirstOrDefault(r => r.Id == id);
    if (roomToDelete is null)
    {
        return Results.NotFound();
    }
    rooms.Remove(roomToDelete);

    return Results.Ok(rooms);
})
.WithName("DeleteRoom");

// Messages
app.MapGet("/rooms/{roomId}/messages", (string roomId) =>
{
    if (messages.All(m => m.RoomId != roomId))
    {
        return Results.NotFound();
    }
    return Results.Ok(messages.Where(m => m.RoomId == roomId));
})
.WithName("GetMessages");

app.MapPost("/rooms/{roomId}/messages", (SendMessageRequest request) =>
{
    if (string.IsNullOrWhiteSpace(request.Text))
    {
        return Results.BadRequest();
    }

    if (rooms.All(r => r.Id != request.RoomId))
    {
        return Results.NotFound();
    }
    
    var message = new Message(generateId(), request.RoomId, request.Text, "user", DateTime.UtcNow);
    messages.Add(message);
    return Results.Ok(message);
})
.WithName("SendMessage");

app.Run();

record Room(string Id, string Name, DateTime CreatedAt);
record Message(string Id, string RoomId, string Text, string UserId, DateTime SentAt);

record CreateRoomRequest(string Name);
record SendMessageRequest(string RoomId, string Text);