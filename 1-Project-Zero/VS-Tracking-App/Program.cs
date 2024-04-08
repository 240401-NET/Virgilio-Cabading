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

        // // Test the Patient Class Methods
        // appTester.TestPatientClass();

        // // Test Vital Sign Class Methods
        // appTester.TestVitalSignClass();

        // *** Fields ******
        PatientController patientControl = new PatientController();

        // Test Patient Controller Find Patient
        
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("  Testing Patient Controller Find Patient");
        Console.WriteLine("-----------------------------------------\n");

        Patient foundPatient = patientControl.GetPatient("harry", "potter");

        Console.WriteLine("------------------------------------------");
        Console.WriteLine($"Found: {foundPatient}");
        Console.WriteLine("------------------------------------------\n");
        DisplayUtil.HoldTerminal();

        // Create implicit patients for development
        // patientControl.AddPatient(new Patient("John", "Doe", 46));
        // patientControl.AddPatient(new Patient("Juan", "Manuel", 23));
        // patientControl.AddPatient(new Patient("Maria Clara", "Elizabeth", 21));

        // Execute the Main Menu
        MainMenu mainMenu = new();
        mainMenu.Execute(patientControl);
    }
}
