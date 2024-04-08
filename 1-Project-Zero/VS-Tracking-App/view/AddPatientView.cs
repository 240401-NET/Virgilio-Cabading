namespace VS_Tracking_App;

class AddPatientView
{
    private Patient RetrieveNewPatientInfoFromTerminal()
    {
        Patient newPatient = new();
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
            newPatient = new Patient();
        }
        return newPatient;
    }

    private bool ValidatePatient(Patient patient)
    {
        bool isValid = true;

        if (!patient.IsValidFirstName())
        {
            isValid = false;
            DisplayUtil.OutputMessage("Patient first name must be at least two characters in length");
        }

        if (!patient.IsValidLastName())
        {
            isValid = false;
            DisplayUtil.OutputMessage("Patient last name must be at least two characters in length");
        }

        if (!patient.IsValidAge())
        {
            isValid = false;
            DisplayUtil.OutputMessage("Patient age must be a positive integer");
        }

        return isValid;
    }

    public void Execute(PatientController patientControl)
    {


        // Output header
        DisplayUtil.DisplayProgramHeader();
        DisplayUtil.WindowHeader("Add New Patient");

        // Instance of a New Patient
        // Retrieve Patient informatin from the terminal
        Patient? newPatient = RetrieveNewPatientInfoFromTerminal();

        // Validate New Patient
        bool isValidPatient = ValidatePatient(newPatient);

        // If the patient format is invalid, exit out of adding a patient
        if (!isValidPatient)
        {
            DisplayUtil.OutputMessage("Invalid patient format.  Patient NOT created");
            DisplayUtil.HoldTerminal();
            return;
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
            DisplayUtil.HoldTerminal();
            new PatientView().Execute(newlyAddedPatient, patientControl);
        }
        else
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\tERROR: Patient was Not Added");
            Console.WriteLine("------------------------------------------\n");
            DisplayUtil.HoldTerminal();
        }
    }
}