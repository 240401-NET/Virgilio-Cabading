using System.Security.Cryptography.X509Certificates;

namespace VS_Tracking_App;

/// <summary>
/// Contains CRUD operations for patients
/// </summary>
class PatientController
{
    // *** Fields ******

    // List of Patients
    private List<Patient> _patientList;

    // *** Constructors ******

    /// <summary>
    ///     Default constructor
    /// </summary>
    public PatientController()
    {
        // Initialize the list of patients from the data file
        _patientList = DataPersistanceUtil.LoadPatients();
    }

    // *** Create ******

    /// <summary>
    ///     Adds a new patient
    /// </summary>
    /// <param name="newPatient">instance of a new patient</param>
    /// <returns>
    ///     Returns instance of patient that was added.\n
    ///     Returns null if no new patient was addeda
    /// </returns>
    public Patient? AddPatient(Patient? newPatient)
    {
        // Detect edge case: given a null instead of a new patient
        if (newPatient == null)
        {
            return null;
        }

        // Add new patient the the patient list
        _patientList.Add(newPatient);

        // Make sure patient list persists past application shut down
        DataPersistanceUtil.SavePatients(_patientList);

        return newPatient;
    }

    // *** Retrieve ******

    /// <summary>
    ///     Retrieves all the patients
    /// </summary>
    /// <returns>list of patients</returns>
    public List<Patient> GetAllPatients()
    {
        return _patientList;
    }

    /// <summary>
    ///     Retrieves patient that matches the 
    ///     first and last names given a parameters
    /// </summary>
    /// <param name="targetFirstName"></param>
    /// <param name="targetLastName"></param>
    /// <returns>Patient that was found whom matches the given first and last name</returns>
    public Patient GetPatient(string targetFirstName, string targetLastName)
    {
        // Create a target patient
        Patient targetPatient = new Patient(targetFirstName, targetLastName, 1);

        // Find a patient the Equals the target patient
        //      if target patient is not found
        //      a default patient will be returned
        return _patientList.Find(patient => patient.Equals(targetPatient)) ?? new Patient();
    }

    // *** Update ******
    // *** Delete ******

    /// <summary>
    ///     Deletes all patients
    /// </summary>
    /// <returns>Returns true if all the patients were deleted</returns>
    public bool DeleteAllPatients()
    {
        _patientList = new List<Patient>();
        return true;
    }
}