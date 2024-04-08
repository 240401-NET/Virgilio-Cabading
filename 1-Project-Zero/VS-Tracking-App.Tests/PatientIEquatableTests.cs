namespace VS_Tracking_App.Tests;

public class PatientIEquatableTests
{
    /// <summary>
    ///     Check to see if patient's .Equal methods returns 
    ///     true if the first name and last name of two patients are the same
    /// </summary>
    [Theory]
    [InlineData("FIRST", "LAST", "first", "last")]
    [InlineData("John", "Doe", "jOHN", "dOE")]
    [InlineData("MARY", "jane", "mary", "JANE")]
    public void Patient_Equals_ReturnsTrueIfBothFirstAndLastNamesInLowerCaseAreEqual
    (
        string p1FirstName, string p1LastName,
        string p2FirstName, string p2LastName
    )
    {
        // Arrange
        Patient patient1 = new Patient(p1FirstName, p1LastName, 1);
        Patient patient2 = new Patient(p2FirstName, p2LastName, 2);

        // Act
        bool result = patient1.Equals(patient2);

        // Assert
        Assert.True(result);
    }

    /// <summary>
    ///     Check to see if the Patient Class's .Equal method
    ///     returns false if the first and last name of two 
    ///     patients are not the same
    /// </summary>
    [Theory]
    [InlineData("FIRST", "LAST", "Dex", "last")]
    [InlineData("John", "Doe", "jOHN", "DEER")]
    [InlineData("MARY", "jane", "mary", "JAin")]
    public void Patient_Equals_ReturnsFalseIfTheFirstNameAndLastNamesOfTwoPatientsAreNotTheSame
    (
        string p1FirstName, string p1LastName,
        string p2FirstName, string p2LastName
    )
    {
        // Arrange
        Patient patient1 = new Patient(p1FirstName, p1LastName, 1);
        Patient patient2 = new Patient(p2FirstName, p2LastName, 2);

        // Act
        bool result = patient1.Equals(patient2);

        // Assert
        Assert.False(result);
    }

    /// <summary>
    ///     Check to see if patient's == operator returns 
    ///     true if the first name and last name of two patients are the same
    /// </summary>
    [Theory]
    [InlineData("FIRST", "LAST", "first", "last")]
    [InlineData("John", "Doe", "jOHN", "dOE")]
    [InlineData("MARY", "jane", "mary", "JANE")]
    public void Patient_WqualsOperator_ReturnsTrueIfBothFirstAndLastNamesInLowerCaseAreEqual
    (
        string p1FirstName, string p1LastName,
        string p2FirstName, string p2LastName
    )
    {
        // Arrange
        Patient patient1 = new Patient(p1FirstName, p1LastName, 1);
        Patient patient2 = new Patient(p2FirstName, p2LastName, 2);

        // Act
        bool result = patient1 == patient2;

        // Assert
        Assert.True(result);
    }

    /// <summary>
    ///     Check to see if the Patient Class's equal operator
    ///     returns false if the first and last name of two 
    ///     patients are not the same
    /// </summary>
    [Theory]
    [InlineData("FIRST", "LAST", "Dex", "last")]
    [InlineData("John", "Doe", "jOHN", "DEER")]
    [InlineData("MARY", "jane", "mary", "JAin")]
    public void Patient_Equals_ReturnsFalseIfTheFirstNameAndLastNamesOfTwoPatientsAreNotTheSame
    (
        string p1FirstName, string p1LastName,
        string p2FirstName, string p2LastName
    )
    {
        // Arrange
        Patient patient1 = new Patient(p1FirstName, p1LastName, 1);
        Patient patient2 = new Patient(p2FirstName, p2LastName, 2);

        // Act
        bool result = patient1 == patient2] 1;

        // Assert
        Assert.False(result);
    }
}