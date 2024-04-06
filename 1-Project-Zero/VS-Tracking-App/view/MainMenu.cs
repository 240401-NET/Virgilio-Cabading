namespace VS_Tracking_App;

/// <summary>
///     Main Menu Class
/// </summary>

class MainMenu
{
    // *** Fields ******
    private int _menuSelection = 0;

    /// <summary>
    ///     Outputs the Main Menu to the Terminal
    /// </summary>
    private void DisplayMainMenu()
    {
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("  Main Menu:");
        Console.WriteLine("------------------------------------------\n");
        Console.WriteLine("(1) - Add New Patient");

        Console.WriteLine("(8) - View List of Existing Patients");
        Console.WriteLine("(9) - Quit\n");
        Console.WriteLine("------------------------------------------\n");
    }

    /// <summary>
    ///     Retrieves an integer from the terminal
    /// </summary>
    /// <returns>The Menu Selection as an integer</returns>
    private int RetrieveMenuSelection()
    {
        try
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine($"{e.Message}\nEntry was invalid. Please try again.\n");
            DisplayUtil.HoldTerminal();
            return 0;
        }
    }

    /// <summary>
    ///     Runs the Main Menu of the Application
    /// </summary>
    /// <param name="patientList">List of Exispatient Patients</param>
    public void Execute(PatientController patientControl)
    {
        // Keep the Main Mehnu running until the user selects to quit 
        while (_menuSelection != 9)
        {
            DisplayUtil.DisplayProgramHeader();

            // Display the possible choices for the Main Menu
            DisplayMainMenu();

            // Get a Menu Selection from the terminal
            Console.WriteLine("Enter a selection:\n");
            _menuSelection = this.RetrieveMenuSelection();

            // Execute selected action
            if (_menuSelection == 1)
            {
                // View for Adding Patient
                AddPatientView addPatientViewer = new();
                addPatientViewer.Execute(patientControl);
            }
            else if (_menuSelection == 8)
            {
                // View of All the patients
                ViewAllPatientsView viewAllPatientsViewer = new();
                viewAllPatientsViewer.Execute(patientControl);
            }
        }
    }
}