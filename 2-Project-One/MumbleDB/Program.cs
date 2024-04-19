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

// // Create a User using Object Initializer
// User newUser = new User 
// {
//     Name = "Raphael",
//     Password = "Red",
// };

// // Use DB Context to Add a new user 
// dbContext.Users.Add(newUser);

// // Execute transaction (Save the add we did to the database)
// dbContext.SaveChanges();

// /// Update User
// // Get user from DB
// User userToUpdate = dbContext.Users.Where(u => u.Name == "Raphael").FirstOrDefault();
// // Modify the local user
// userToUpdate.Password = "R3d";
// // Use DB Context to do update
// dbContext.Users.Update(userToUpdate);
// // Save changes to Database
// dbContext.SaveChanges();

// Get all users
IEnumerable<User> users = dbContext.Users;
Console.WriteLine($"Number of Users: {users.Count()}");

Console.WriteLine("Users:");
foreach (User user in users) 
{
    Console.WriteLine(user.Name);
}