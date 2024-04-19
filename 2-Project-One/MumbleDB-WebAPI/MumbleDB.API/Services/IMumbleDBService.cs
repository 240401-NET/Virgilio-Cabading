using MumbleDB.Models;

namespace MumbleDB.Services;

public interface IMumbleDBService
{
    // *** Create ******
    
    public User AddNewUser(User newUser);

    // *** Retrieve ******

    IEnumerable<User> GetAllUsers();
    public User GetUserById(int id);

    // *** Update ******
    
    // *** Delete******

    public User DeleteUserById(int targetId);
}