// See https://aka.ms/new-console-template for more information
using MumbleDB;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("/////////////////////////////");
Console.WriteLine("Mumble DB:\n");

// build the connection string
string connectionString = File.ReadAllText("ConnectionString.txt");

// build the connection to Azure DB
var optionsBuilder = new DbContextOptionsBuilder<_240415CabadingProj1Context>();
optionsBuilder.UseSqlServer (connectionString);

// build a database context
_240415CabadingProj1Context dbContext = new _240415CabadingProj1Context(optionsBuilder.Options);

// Get all users
IEnumerable<User> users = dbContext.Users;
Console.WriteLine($"Number of Users: {users.Count()}");

Console.WriteLine("Users:");
foreach (User user in users) 
{
    Console.WriteLine(user.Name);
}