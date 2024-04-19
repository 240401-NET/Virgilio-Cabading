using MumbleDB.Models;
using MumbleDB.Data;
using System.Text.RegularExpressions;

namespace MumbleDB.Services;

public class MumbleDBService : IMumbleDBService
{
    // *** Constructors ******
    private readonly IMumbleDBRepository _mRepo;

    public MumbleDBService(IMumbleDBRepository mRepo) => _mRepo = mRepo;

    // *** Create ******

    public User AddNewUser(User newUser)
    {
        newUser.Name = newUser.Name.ToLower();
        
        // Test if username already exists
        User foundUser = _mRepo.GetUserByName(newUser.Name);

        // If username already exists, cannot create new user
        if (foundUser != null)
        {
            throw new Exception("Cannot Create User, User Name already exists");
        }
        return _mRepo.AddNewUser(newUser);
    }

    // *** Retrieve ******

    public IEnumerable<User> GetAllUsers()
    {
        return _mRepo.GetAllUsers();
    }

    public User GetUserById(int id)
    {
        User foundUser = _mRepo.GetUserById(id);
        if (foundUser == null)
        {
            throw new Exception("User not found");
        }
        return foundUser;
    }

    // *** Update ******

    // *** Delete ******

    public User DeleteUserById(int targetId)
    {
        // Find the user to delete
        User userToDelete = _mRepo.GetUserById(targetId);

        // If user to delete was not found, throw exception
        if (userToDelete == null)
        {
            throw new Exception("Invalid ID, cannot delete user");
        }

        // Delete the user
        return _mRepo.DeleteUser(userToDelete);
    }
}