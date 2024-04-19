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

    // *** Update ******
    // *** Delete ******

    public User DeleteUser(User userToDelete);
}