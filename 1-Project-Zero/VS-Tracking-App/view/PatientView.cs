namespace VS_Tracking_App;

class PatientView
{

    // *** Methods ******

    /// <summary>
    ///     Outputs the Menu to the Terminal
    /// </summary>
    private void DisplayMenu()
    {
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("  Possible Actions:");
        Console.WriteLine("------------------------------------------\n");
        Console.WriteLine("(1) - Add a Vital Sign");
        Console.WriteLine("(2) - View all of Patient's Vital Signs");
        Console.WriteLine("(8) - Delete Patient");
        Console.WriteLine("(0) - Return to Main Menu\n");
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
            Console.WriteLine($"{e.Message}S\n");
            return -1;
        }
    }

    public void Execute(Patient patient, PatientController patientContol)
    {
        int menuSelection = -1;
        while (menuSelection != 0)
        {
            // Output Header
            DisplayUtil.DisplayProgramHeader();
            DisplayUtil.WindowHeader("Patient View:");

            // Debuging output to see if patient was found
            Console.WriteLine(patient);

            // Display the menu and get the user's choice of action
            DisplayMenu();
            menuSelection = RetrieveMenuSelection();

            // Execute Selected Action
            switch (menuSelection)
            {
                // Quit
                case 0:
                    break;
                case 1:
                    // Add Vital Signs
                    new AddVitalSignView().Execute(patient, patientContol); 
                    break;
                // View all of patient's Vital Signs
                case 2:
                    DisplayUtil.OutputMessage("View All of Patient's Vital Signs View:");
                    DisplayUtil.HoldTerminal();
                    break;
                // Delete patient
                case 8:
                    new DeletePatientView().Execute(patient, patientContol);
                    return;
                // Catch all other cases
                default:
                    DisplayUtil.OutputMessage("Error: Invalid Menu Selection");
                    DisplayUtil.HoldTerminal();
                    break;
            }
        }
    }
}