using Microsoft.EntityFrameworkCore;
using SmartWorkspace.Application.Interfaces;
using SmartWorkspace.Infrastructure;
using SmartWorkspace.Infrastructure.Extensions;
using SmartWorkspace.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

//Add EF Core DbContext

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// ⬇ Add Identity + JWT Auth
builder.Services.AddIdentityInfrastructure(builder.Configuration);

// ⬇️ Register JwtService implementation
builder.Services.AddScoped<IJwtService, JwtService>();

// ⬇ Add CORS (so React can talk to API)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
// Enable HTTPS redirection and middleware

app.UseHttpsRedirection();
app.UseCors("AllowAll");           //  Allow React frontend
app.UseAuthentication();           //  JWT Middleware
app.UseAuthorization();

app.MapControllers();              // Enable API controller routes

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

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
