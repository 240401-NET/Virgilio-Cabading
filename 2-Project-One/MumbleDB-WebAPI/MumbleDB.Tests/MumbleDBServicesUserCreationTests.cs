using Moq;
using MumbleDB.Controllers;
using MumbleDB.Data;
using MumbleDB.Models;
using MumbleDB.Services;

namespace MumbleDB.Tests;

public class MumbleDBServicesUserCreationTests
{
    [Fact]
    public void MumbleDBService_AddNewUser_CreateASingleNewUser()
    {
        // Arrange
        Mock<IMumbleDBRepository> mockRepo = new Mock<IMumbleDBRepository>();
        User mockUser = new User
        {
            Name = "JohnDoe",
            Password = "test"
        };
        mockRepo.Setup(r => r.AddNewUser(mockUser)).Returns(mockUser);
        MumbleDBService service = new MumbleDBService(mockRepo.Object);

        // Act
        User newUser = service.AddNewUser(mockUser);

        // Assert
        Assert.Equal(mockUser.Name, newUser.Name);
        Assert.Equal(mockUser.Password, newUser.Password);
    }
}