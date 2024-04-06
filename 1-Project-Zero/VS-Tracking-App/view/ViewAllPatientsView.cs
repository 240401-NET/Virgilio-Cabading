namespace VS_Tracking_App;

class ViewAllPatientsView
{
    public void Execute(List<User> patientList)
    {
        DisplayUtil.DisplayProgramHeader();

        Console.WriteLine("------------------------------------------");
        Console.WriteLine("  Display All Patients:");
        Console.WriteLine("------------------------------------------\n");

        DisplayUtil.HoldTerminal();
    }
}