namespace VS_Tracking_App;

/// <summary>
///     Vital Signs Tracking Application
/// </summary>

class Program
{
    // *** Main Application ******
    static void Main(string[] args)
    {
        // *** Fields ******
        PatientController patientControl = new PatientController();

        // Execute the Main Menu
        MainMenu mainMenu = new();
        mainMenu.Execute(patientControl);
    }
}
