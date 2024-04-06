namespace VS_Tracking_App;

/// <summary>
///     Vital Signs Tracking Application
/// </summary>

class Program
{
    // *** Main Application ******
    static void Main(string[] args)
    {
        // *** TEST AREA ******
        
        // DisplayUtil.DisplayProgramHeader();

        // Test appTester = new();

        // // Test the User Class Methods
        // appTester.TestUserClass();

        // // Test Vital Sign Class Methods
        // appTester.TestVitalSignClass();

        // *** Fields ******
        List<User> patientList = new List<User>();

        // Execute the Main Menu
        MainMenu mainMenu = new();
        patientList = mainMenu.Execute(patientList);
    }
}
