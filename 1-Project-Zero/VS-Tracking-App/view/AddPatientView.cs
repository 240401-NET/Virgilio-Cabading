namespace VS_Tracking_App;

class AddPatientView
{

    public void Execute(PatientController patientControl)
    {
        // *** Fields ******

        // Instance of a New Patient
        Patient? newPatient = new Patient();


        // Output header
        DisplayUtil.DisplayProgramHeader();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("  Add New Patient:");
        Console.WriteLine("------------------------------------------\n");

        // Rewtrieve Patient informatin from the terminal
        Console.WriteLine("Enter new patient's information:\n");
        try
        {
            Console.Write("First Name:\t");
            newPatient.FirstName = Console.ReadLine() ?? "unknown";

            Console.Write("Last Name:\t");
            newPatient.LastName = Console.ReadLine() ?? "unknown";

            Console.Write("Age:\t");
            newPatient.Age = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}\nError in retieving patient information from the terminal.");
            newPatient = null;
        }

        // Add new patient
        Patient? newlyAddedPatient = patientControl.AddPatient(newPatient);

        // Check if patient was added successfully
        if (newlyAddedPatient != null)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\tNew Patient Successfully Added");
            Console.WriteLine($"{newlyAddedPatient}");
            Console.WriteLine("------------------------------------------\n");

        }
        else
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\tERROR: Patient was Not Added");
            Console.WriteLine("------------------------------------------\n");
        }
        Console.WriteLine("");

        DisplayUtil.HoldTerminal();
}
}