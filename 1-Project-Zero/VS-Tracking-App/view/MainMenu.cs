namespace VS_Tracking_App;

/// <summary>
///     Main Menu Class
/// </summary>

class MainMenu
{
    // *** Fields ******
    private int _menuSelection = -1;

    /// <summary>
    ///     Outputs the Main Menu to the Terminal
    /// </summary>
    private void DisplayMainMenu()
    {
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("  Main Menu:");
        Console.WriteLine("------------------------------------------\n");
        Console.WriteLine("(1) - Add New Patient");
        Console.WriteLine("(2) - View List of Existing Patients");
        Console.WriteLine("(3) - Find a Patient");
        Console.WriteLine("(0) - Quit\n");
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
            return -1;
        }
    }

    /// <summary>
    ///     Runs the Main Menu of the Application
    /// </summary>
    /// <param name="patientList">List of Exispatient Patients</param>
    public void Execute(PatientController patientControl)
    {
        // Keep the Main Mehnu running until the user selects to quit 
        while (_menuSelection != 0)
        {
            DisplayUtil.DisplayProgramHeader();

            // Display the possible choices for the Main Menu
            DisplayMainMenu();

            // Get a Menu Selection from the terminal
            Console.WriteLine("Enter a selection:\n");
            _menuSelection = this.RetrieveMenuSelection();

            // Execute selected action
            switch (_menuSelection)
            {
                // View for Adding Patient
                case 1:
                    AddPatientView addPatientViewer = new();
                    addPatientViewer.Execute(patientControl);
                    break;
                // View of All the patients
                case 2:
                    ViewAllPatientsView viewAllPatientsViewer = new();
                    viewAllPatientsViewer.Execute(patientControl);
                    break;
                case 3:
                    FindPatientView findPatientViewer = new();
                    findPatientViewer.Execute(patientControl);
                    break;
                case 0:
                    DisplayUtil.OutputMessage("Good bye");
                    break;
            }
        }
    }
}