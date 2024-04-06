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

        // Create implicit patients for development
        patientList.Add(new User("John", "Doe", 46));
        patientList.Add(new User("Juan", "Manuel", 23));
        patientList.Add(new User("Maria Clara", "Elizabeth", 21));

        // Execute the Main Menu
        MainMenu mainMenu = new();
        patientList = mainMenu.Execute(patientList);
    }
}
