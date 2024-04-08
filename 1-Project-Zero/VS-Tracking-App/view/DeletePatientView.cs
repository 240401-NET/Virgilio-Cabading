namespace VS_Tracking_App;

class DeletePatientView
{
    public void Execute(Patient patient, PatientController patientContol)
    {
        // Output Header
        DisplayUtil.DisplayProgramHeader();
        DisplayUtil.WindowHeader("Deleting Patient:");

        DisplayUtil.OutputMessage($"{patient}");
        DisplayUtil.HoldTerminal();

        // Delete Patient
        bool patientDeleted = patientContol.DeletePatient(patient);

        // Display success message if deletion was successful
        if (patientDeleted)
        {
            DisplayUtil.OutputMessage("Patient deleted!");
            DisplayUtil.HoldTerminal();
        }
        // Display warning message if deletion was NOT successful
        else
        {
            DisplayUtil.OutputMessage("Error: patient NOT deleted");
            DisplayUtil.HoldTerminal();
        }
    }
}