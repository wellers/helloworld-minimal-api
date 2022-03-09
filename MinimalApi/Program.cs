var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IUser, User>(provider => new User { Name = "Paul" });

var app = builder.Build();

app.MapGet("HelloWorld", () =>
{
    using var scope = app.Services.CreateScope();
    var user = scope.ServiceProvider.GetRequiredService<IUser>();
    return $"HelloWorld {user.Name}";
});

app.Run();

interface IUser
{
    string Name { get; set; }
}

class User : IUser
{
    public string Name { get; set; }
}