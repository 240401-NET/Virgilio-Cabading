using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using MumbleDB.Models;
using MumbleDB.Data;
using MumbleDB.Services;

namespace MumbleDB.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MumbleDBController : ControllerBase
{
    private readonly IMumbleDBService _mService;
    private readonly IMumbleDBRepository _mRepo;

    public MumbleDBController(IMumbleDBRepository newMRepo, IMumbleDBService service)
    {
        // _mService = newMService;
        _mRepo = newMRepo;
        _mService = service;
    }

    // Root API Route
    [HttpGet]
    public ActionResult<string> Get()
    {
        return Ok("Welcome to Mumble Chat's API");
    }

    // *** Create ******

    // *** Retrieve ******

    [HttpGet("Users")]
    public IEnumerable<User> GetUsers()
    {
        //     try
        //     {
        //         var users = _mService.GetAllUsers();
        //         return Ok(users);
        //     }
        //     catch (Exception ex)
        //     {
        //         return Problem(ex.Message);
        //     }

        // return _mService.GetAllUsers();
        return _mService.GetAllUsers();
    }


    // *** Update ******

    // *** Delete ******

}