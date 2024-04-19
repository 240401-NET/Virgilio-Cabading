using Microsoft.EntityFrameworkCore;
using MumbleDB.Models;

namespace MumbleDB.Data;

public interface IMumbleDBRepository
{


    // *** Create ******

    User AddNewUser(User newUser);

    // *** Retrieve ******

    IEnumerable<User> GetAllUsers();
    User GetUserById(int id);
    User GetUserByName(string name);

    // *** Update ******
    // *** Delete ******

    public User DeleteUser(User userToDelete);
}