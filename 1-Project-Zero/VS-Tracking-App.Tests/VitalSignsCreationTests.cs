namespace VS_Tracking_App.Tests;

public class VitalSignsCreationTests
{
    /// <summary>
    /// Test to make sure the defult constructor for Vital Sign 
    /// Class returns an instance 
    /// with BP at -1/-1 and HR -1
    /// </summary>
    [Fact]
    public void VitalSign_DefaultConstructor_ReturnsBPAndHRSetToDefaultValues()
    {
        // Arrange

        // Act
        VitalSign newDefaultVitalSign = new();

        // Assert
        // Expect Vital Sign values of: BP -1/-1 and HR: -1
        Assert.Equal(-1, newDefaultVitalSign.SystolicBP);
        Assert.Equal(-1, newDefaultVitalSign.DiastolicBP);
        Assert.Equal(-1, newDefaultVitalSign.HeartRate);
    }

    /// <summary>
    /// Test the parameterized constructor of the Vital Sign class
    /// </summary>
    /// <param name="expectedSystolicBP">Systolic Blood Pressure as an integer</param>
    /// <param name="expectedDiastolicBP">Diastolic Blood Pressure as an integer</param>
    /// <param name="expectedHeartRate">Heart Rate (bears per minute) as an integer</param>
    [Theory]
    [InlineData(120, 80, 75)]
    [InlineData(90, 60, 65)]
    public  void VitalSign_ThreeParamConstructor_ReturnsBPAndHRSetToValuePassedInParam(
        int expectedSystolicBP,
        int expectedDiastolicBP,
        int expectedHeartRate)
    {
        // Arrange

        // Act
        VitalSign newVitalSign = new(expectedSystolicBP, expectedDiastolicBP, expectedHeartRate);

        // Assert
        Assert.Equal(expectedSystolicBP, newVitalSign.SystolicBP);
        Assert.Equal(expectedDiastolicBP, newVitalSign.DiastolicBP);
        Assert.Equal(expectedHeartRate, newVitalSign.HeartRate);
    }
}