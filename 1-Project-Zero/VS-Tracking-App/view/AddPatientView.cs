namespace VS_Tracking_App;

class AddPatientView
{
    public List<User> Execute(List<User> patientList)
    {
        DisplayUtil.DisplayProgramHeader();

        Console.WriteLine("------------------------------------------");
        Console.WriteLine("  Add New Patient:");
        Console.WriteLine("------------------------------------------\n");

        DisplayUtil.HoldTerminal();

        return patientList;
    }
}