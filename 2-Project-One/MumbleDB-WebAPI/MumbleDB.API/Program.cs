using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MumbleDB.Data;
using MumbleDB.Models;
using MumbleDB.Services;

var builder = WebApplication.CreateBuilder(args);

// *** Add Dependencies to the services container ******

// Add the DB Context to Services
builder.Services.AddDbContext<MumbleDBContext>(option => option.UseSqlServer(builder.Configuration["dbconnectionstr"]));

// Add DB Repository to Services
builder.Services.AddScoped<IMumbleDBRepository, MumbleDBRepository>();

builder.Services.AddScoped<IMumbleDBService, MumbleDBService>();

builder.Services.AddControllers()
.AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
        });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger App
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// *** Configure the HTTP request pipeline ***

// Convert http requests to https
app.UseHttpsRedirection();

// Mapping for Weather API
app.MapGet("/", () =>
{
    return "Welcome to Mumble Chat";
})
.WithName("Roots")
.WithOpenApi();

// // Post Mapping for Create a User
// app.MapPost("/User", (IMumbleDBRepository repo, User userToAdd) => {
//     return repo.AddNewUser(userToAdd);
// })
// .WithName("Add New User")
// .WithOpenApi();

// Get All Users
app.MapGet("Users", (IMumbleDBRepository repo) => {
    return repo.GetAllUsers();
})
.WithName("Get All Users")
.WithOpenApi();

// Enable controllers
app.MapControllers();

// Run the Server
app.Run();