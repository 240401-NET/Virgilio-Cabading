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

    [Fact]
    public void MumbleDBService_GetAllUsers_ReturnsListOfUsers()
    {
        // Arrange
        Mock<IMumbleDBRepository> mockRepo = new Mock<IMumbleDBRepository>();
        User mockUser1 = new User
        {
            Name = "John",
            Password = "test"
        };
        User mockUser2 = new User
        {
            Name = "Marie",
            Password = "quiz"
        };
        List<User> mockUsersList = new List<User>();
        mockUsersList.Add(mockUser1);
        mockUsersList.Add(mockUser2);
        mockRepo.Setup(r => r.GetAllUsers()).Returns(mockUsersList);

        MumbleDBService service = new MumbleDBService(mockRepo.Object);
        service.AddNewUser(mockUser1);
        service.AddNewUser(mockUser2);

        // Action
        IEnumerable<User> allUsers = service.GetAllUsers();

        // Assert
        Assert.True(allUsers.Count() == 2);
        Assert.True(allUsers.Contains(mockUser1));
        Assert.False(allUsers.Contains(new User()));
    }
}