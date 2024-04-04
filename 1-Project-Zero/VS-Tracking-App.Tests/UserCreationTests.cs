namespace VS_Tracking_App.Tests;

public class UserCreationTests
{
    /// <summary>
    /// Test to make sure that the default constructor returns an instance
    /// of User with Name and Age set to: "unknown unknown" & -1
    /// </summary>
    [Fact]
    public void User_DefaultConstructor_ReturnsFirstNameLastNameAndAgeSetToDefaultValues()
    {
        // Arrange

        // Act
        User newDefaultUser = new();

        // Assert
        // Test that the create user has:
        // First name: unknown | Last name: unknown | Age: -1
        Assert.Equal( "unknown", newDefaultUser.FirstName );
        Assert.Equal( "unknown", newDefaultUser.LastName );
        Assert.Equal(-1, newDefaultUser.Age );
    }

    /// <summary>
    /// Test the Three parameter Constructor
    /// </summary>
    /// <param name="expectedFirstName">First name in string format</param>
    /// <param name="expectedLastName">Last name in string format</param>
    /// <param name="expectedAge">Age in years as an integer</param>
    [Theory]
    [InlineData("Humpty", "Dumpty", 16)]
    [InlineData("Mother", "Goose", 56)]
    public void User_ThreeParamConstructor_ReturnsFirstNameLastNameAndAgeSetToValuesPassedInParam( 
        string expectedFirstName, 
        string expectedLastName, 
        int expectedAge)
    {
        // Arrange

        // Act
        User newUser = new(expectedFirstName, expectedLastName, expectedAge);

        // Assert
        Assert.Equal(expectedFirstName, newUser.FirstName);
        Assert.Equal(expectedLastName, newUser.LastName);
        Assert.Equal(expectedAge, newUser.Age);
    }
}