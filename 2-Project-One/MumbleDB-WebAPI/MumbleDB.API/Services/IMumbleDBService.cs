using MumbleDB.Models;

namespace MumbleDB.Services;

public interface IMumbleDBService
{
    IEnumerable<User> GetAllUsers();
}