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

    [HttpPost("Users")]
    public ActionResult<User> Post(User newUser)
    {
        try
        {
            return _mService.AddNewUser(newUser);
        }
        catch (Exception ex)
        {
            return Problem(ex.Message);
        }
    }

    // *** Retrieve ******

    [HttpGet("Users")]
    public ActionResult<IEnumerable<User>> GetUsers()
    {
        try
        {
            return Ok(_mService.GetAllUsers());
        }
        catch (Exception ex)
        {
            return Problem(ex.Message);
        }
    }

    [HttpGet("Users/{targetId}")]
    public ActionResult<User> GetUserById(int targetId)
    {
        try
        {
            User foundUser = _mService.GetUserById(targetId);
            return Ok(foundUser);
        }
        catch (Exception ex)
        {
            return Problem(ex.Message);
        }
    }


    // *** Update ******

    // *** Delete ******

    [HttpDelete("Users/{targetId}")]
    public ActionResult<User> DeleteUserById(int targetId)
    {
        try
        {
            // User deletedUser = new();
            // deletedUser.UserId = targetId;
            // return deletedUser;
            return _mService.DeleteUserById(targetId);
        }
        catch (Exception ex)
        {
            return Problem(ex.Message);
        }
    }

}