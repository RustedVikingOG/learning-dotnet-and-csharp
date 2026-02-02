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

var rooms = new List<Room>();
var messages = new List<Message>();

// ROOMS ENDPOINTS
app.MapGet("/rooms", () =>
{
    return Results.Ok(rooms);
}).WithName("GetRooms");

app.MapGet("/rooms/{id}", (string id) =>
{
    var room = rooms.FirstOrDefault(r => r.Id == id);
    return room is not null ? Results.Ok(room) : Results.NotFound();
}).WithName("GetRoomById");

app.MapPost("/rooms", (RoomNameRequest request) =>
{
    var newRoom = new Room(Guid.NewGuid().ToString(), request.Name, DateTime.Now);
    rooms.Add(newRoom);
    return Results.Ok(newRoom);
}).WithName("CreateRoom");

app.MapDelete("/rooms/{id}", (string id) =>
{
    var room = rooms.FirstOrDefault(r => r.Id == id);
    if (room is not null)
    {
        rooms.Remove(room);
        return Results.Ok();
    }
    return Results.NotFound();
}).WithName("DeleteRoom");

// MESSAGES ENDPOINTS
app.MapGet("/rooms/{id}/messages", (string id) =>
{
    var roomMessages = messages.Where(m => m.RoomId == id).ToList();
    return Results.Ok(roomMessages);
}).WithName("GetMessagesByRoomId");

app.MapPost("/rooms/{id}/messages", (MessageRequest request) =>
{
    if (rooms.Any(r => r.Id == request.RoomId))
    {
        var newMessage = new Message(Guid.NewGuid().ToString(), request.RoomId, request.UserId, request.Content, DateTime.UtcNow);
        messages.Add(newMessage);
        return Results.Ok(newMessage);
    }
    return Results.NotFound();
}).WithName("PostMessageToRoom");


app.Run();


record Room(string Id, string Name, DateTime CreatedAt);
record RoomNameRequest(string Name);
record Message(string Id, string RoomId, string UserId, string Content, DateTime SentAt);
record MessageRequest(string UserId, string Content, string RoomId);