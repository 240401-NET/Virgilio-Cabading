namespace VS_Tracking_App;

class AddVitalSignView
{
    private VitalSign? GetVitalSignInfoFromTerminal()
    {
        VitalSign newVitalSign = new();

        Console.WriteLine("Enter new vital signs:");
        try
        {
            Console.Write("Systolic BP\t");
            newVitalSign.SystolicBP = Convert.ToInt32(Console.ReadLine());

            Console.Write("Diastolic BP:\t");
            newVitalSign.DiastolicBP = Convert.ToInt32(Console.ReadLine());

            Console.Write("Heart Rate:\t");
            newVitalSign.HeartRate = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}\nError in retrieving vital sign information from the terminal.");
            return null;
        }

        return newVitalSign;
    }
    public void Execute(Patient patient, PatientController patientControl)
    {
        // Output Header
        DisplayUtil.DisplayProgramHeader();
        DisplayUtil.WindowHeader("Add Vital Signs for Patient:");

        // Show which patient user is working with
        DisplayUtil.OutputMessage($"Patient: {patient}");

        VitalSign? newVitalSign = GetVitalSignInfoFromTerminal();

        // A non-existing vital sign should not be added
        if (newVitalSign == null)
        {
            DisplayUtil.OutputMessage("Error in adding vital sign");
            DisplayUtil.HoldTerminal();
            return;
        }

        // Add new vital sign
        patientControl.AddVitalSign(patient, newVitalSign.SystolicBP, newVitalSign.DiastolicBP, newVitalSign.HeartRate);

        DisplayUtil.OutputMessage($"New Vital Sign Added: {newVitalSign}");
        DisplayUtil.HoldTerminal();
    }
}