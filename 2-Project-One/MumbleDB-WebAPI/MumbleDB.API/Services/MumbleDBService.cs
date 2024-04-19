using MumbleDB.Models;
using MumbleDB.Data;
using System.Text.RegularExpressions;

namespace MumbleDB.Services;

public class MumbleDBService : IMumbleDBService
{
    private readonly IMumbleDBRepository _mRepo;

    public MumbleDBService(IMumbleDBRepository mRepo) => _mRepo = mRepo;

    public IEnumerable<User> GetAllUsers()
    {
        return _mRepo.GetAllUsers();
    }
}