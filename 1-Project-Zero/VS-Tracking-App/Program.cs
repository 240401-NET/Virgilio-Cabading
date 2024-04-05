namespace VS_Tracking_App;

/// <summary>
///     Vital Signs Tracking Application
/// </summary>

class Program
{
    static void Main(string[] args)
    {
        DisplayUtil.ClearTerminal();
        DisplayUtil.DisplayProgramHeader();


        // *** TEST AREA ******

        Test appTester = new();

        // Test the User Class Methods
        appTester.TestUserClass();

        // Test Vital Sign Class Methods
        appTester.TestVitalSignClass();
    }
}
