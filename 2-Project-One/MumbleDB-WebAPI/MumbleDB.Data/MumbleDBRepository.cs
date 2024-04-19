using Microsoft.EntityFrameworkCore;
using MumbleDB.Models;

namespace MumbleDB.Data;

public class MumbleDBRepository : IMumbleDBRepository
{
    private readonly MumbleDBContext _mDbContext;
    public MumbleDBRepository(MumbleDBContext newContext)
    {
        _mDbContext = newContext;
    }

    // *** Create ******

    public User AddNewUser(User newUser)
    {
        _mDbContext.Users.Add(newUser);
        _mDbContext.SaveChanges();
        return newUser;
    }

    // *** Retrieve ******

    public IEnumerable<User> GetAllUsers()
    {
        return _mDbContext.Users.ToList();
    }

    public User GetUserById(int id)
    {
        return _mDbContext.Users.Find(id);
    }

    public User GetUserByName(string name)
    {
        return _mDbContext.Users
                    .Where(u => u.Name == name)
                    .FirstOrDefault();
    }

    // *** Update ******
    // *** Delete ******

    public User DeleteUser(User userToDelete)
    {
        _mDbContext.Users.Remove(userToDelete);
        _mDbContext.SaveChanges();
        return userToDelete;
    }
}
