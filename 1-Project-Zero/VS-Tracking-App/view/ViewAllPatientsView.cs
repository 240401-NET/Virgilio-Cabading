namespace VS_Tracking_App;

class ViewAllPatientsView
{
    /// <summary>
    /// Calculates the number of tabs to create to format after the name in the table output
    /// </summary>
    /// <param name="word">string being measured</param>
    /// <returns>formated tab string output</returns>
    private string FormatNumTabs(string word)
    {
        if (word.Length < 15)
        {
            return "\t\t\t";
        }
        else if (word.Length < 30)
        {
            return "\t\t";
        }
        return "\t";
    }

    /// <summary>
    /// Outputs the All Patient View to the terminal
    /// </summary>
    /// <param name="patientList">List of patients</param>
    public void Execute(PatientController patientControl)
    {
        // *** Fields ******

        List<Patient> patientList = patientControl.GetAllPatients();

        // *** Executable section ******

        // Visual Header
        DisplayUtil.DisplayProgramHeader();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("  Display All Patients:");
        Console.WriteLine("------------------------------------------\n");

        // Output table key
        Console.WriteLine("\tLast Name, First Name \t\t| Age (in years)\n");

        // Output all the patients to the terminal
        for (int i = 0; i < patientList.Count; i++)
        {
            Patient patient = patientList.ElementAt<Patient>(i);
            string tabs = FormatNumTabs($"{patient.LastName}, {patient.FirstName}");
            Console.WriteLine($" ({i+1})\t" +
                                $"{patient.LastName}, {patient.FirstName}" +
                                $"{tabs}| {patient.Age}");
        }
        Console.WriteLine();

        DisplayUtil.HoldTerminal();
    }
}