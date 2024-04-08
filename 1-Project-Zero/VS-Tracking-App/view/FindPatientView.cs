namespace VS_Tracking_App;

class FindPatientView
{
    public void Execute(PatientController patientController)
    {
        // Output header
        DisplayUtil.DisplayProgramHeader();
        DisplayUtil.WindowHeader("Find a patient");

        // Instance of patient this winding is trying to finding
        Patient? foundPatient;

        // Retrieve target patient information from the terminal
        Console.WriteLine("Enter the information of the patient you are attempting to find:");
        try
        {
            Console.Write("First Name:\t");
            string targetFirstName = Console.ReadLine() ?? "unknown";

            Console.Write("Last Name:\t");
            string targetLastName = Console.ReadLine() ?? "unknown";

            foundPatient = patientController.GetPatient(targetFirstName, targetLastName);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}\nError in retieving patient information from the terminal.");
            foundPatient = new Patient();
        }

        // If Patient is FOUND, redirect to Patient View
        if (!foundPatient.IsDefault())
        {
            // Redirect to Patient View
            new PatientView().Execute(foundPatient, patientController);
        }
        // else If Patient NOT found, output error message
        //      then return user to main menu
        else
        {
            DisplayUtil.OutputMessage("Error: Patient NOT found");
            DisplayUtil.HoldTerminal();
        }
    }
}