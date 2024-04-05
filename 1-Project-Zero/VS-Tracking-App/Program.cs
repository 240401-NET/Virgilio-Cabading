namespace VS_Tracking_App;

/// <summary>
///     Vital Signs Tracking Application
/// </summary>

class Program
{
    // *** Main Application ******
    static void Main(string[] args)
    {
        List<User> patientList = new List<User>();

        DisplayUtil.DisplayProgramHeader();

        // *** TEST AREA ******

        // Test appTester = new();

        // // Test the User Class Methods
        // appTester.TestUserClass();

        // // Test Vital Sign Class Methods
        // appTester.TestVitalSignClass();

        // Execute the Main Menu
        MainMenu mainMenu = new();
        mainMenu.Execute(patientList);
    }
}
