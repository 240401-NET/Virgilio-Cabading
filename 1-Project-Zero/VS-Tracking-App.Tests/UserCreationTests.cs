namespace VS_Tracking_App.Tests;

public class PatientCreationTests
{
    /// <summary>
    /// Test to make sure that the default constructor returns an instance
    /// of Patient with Name and Age set to: "unknown unknown" & -1
    /// </summary>
    [Fact]
    public void Patient_DefaultConstructor_ReturnsFirstNameLastNameAndAgeSetToDefaultValues()
    {
        // Arrange

        // Act
        Patient newDefaultPatient = new();

        // Assert
        // Test that the create Patient has:
        // First name: unknown | Last name: unknown | Age: -1
        Assert.Equal( "unknown", newDefaultPatient.FirstName );
        Assert.Equal( "unknown", newDefaultPatient.LastName );
        Assert.Equal(-1, newDefaultPatient.Age );
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
    public void Patient_ThreeParamConstructor_ReturnsFirstNameLastNameAndAgeSetToValuesPassedInParam( 
        string expectedFirstName, 
        string expectedLastName, 
        int expectedAge)
    {
        // Arrange

        // Act
        Patient newPatient = new(expectedFirstName, expectedLastName, expectedAge);

        // Assert
        Assert.Equal(expectedFirstName, newPatient.FirstName);
        Assert.Equal(expectedLastName, newPatient.LastName);
        Assert.Equal(expectedAge, newPatient.Age);
    }
}