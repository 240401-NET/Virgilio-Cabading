namespace VS_Tracking_App;

class ViewAllPatientsView
{
    public void Execute(List<User> patientList)
    {
        // Visual Header
        DisplayUtil.DisplayProgramHeader();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("  Display All Patients:");
        Console.WriteLine("------------------------------------------\n");

        // Output table key
        Console.WriteLine("        Last Name, First Name | Age (in years)");

        // Output all the patients to the terminal
        for (int i=0; i<patientList.Count; i++)
        {
            User patient = patientList.ElementAt<User>(i);
            Console.WriteLine(  $"    ({i}) " + 
                                $"{patient.LastName}, {patient.FirstName}" +
                                $" | {patient.Age}");
        }

        DisplayUtil.HoldTerminal();
    }
}