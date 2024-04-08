namespace VS_Tracking_App;

class PatientVitalSignsView
{
    public void Execute(Patient patient)
    {
        // Output Header
        DisplayUtil.DisplayProgramHeader();
        DisplayUtil.WindowHeader("Vital Signs for Patient:");

        // Show which patient user is working with
        DisplayUtil.OutputMessage($"{patient}");

        List<VitalSign> vitalSignList = patient.VitalSignList;
        foreach (VitalSign vitalSign in vitalSignList)
        {
            Console.WriteLine(vitalSign);
        }

        DisplayUtil.HoldTerminal();
    }

}