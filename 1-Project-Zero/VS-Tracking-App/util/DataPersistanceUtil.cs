using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace VS_Tracking_App;

/// <summary>
///     Provides functionality for persisting data even after main application is done running
/// </summary>
class DataPersistanceUtil
{
    /// <summary>
    ///     Retrieves the patient list from data file
    /// </summary>
    /// <returns>list of patients</returns>
    public static List<Patient> LoadPatients()
    {
        try
        {
            // Read the patient list JSON from the data file
            string filePath = "./data/patientList.json";
            string serializedPatientList = File.ReadAllText(filePath);

            // Convert patient list from JSON into a list of patients
            // Note: if file is empty, than a new patient list will be created
            List<Patient> newlyLoadedPatientList = JsonSerializer.Deserialize<List<Patient>>(serializedPatientList) ?? new List<Patient>();

            return newlyLoadedPatientList;

        }
        catch (Exception e)
        {
            Console.WriteLine($"\nError: {e.Message}\n");
            return new List<Patient>();
        }
    }

    /// <summary>
    ///     Saves the patient list to file
    /// </summary>
    /// <param name="patientList">list of patients</param>
    /// <returns>True if patient list was saved to file</returns>
    public static bool SavePatients(List<Patient> patientList)
    {
        // Edge case: patient list does not exist
        if (patientList == null)
        {
            return false;
        }

        // Serialize list of patients to JSON format
        string serializedPatientList = JsonSerializer.Serialize(patientList);

        string filePath = "./data/patientList.json";

        // Write the JSON verision of patient list to data file
        File.WriteAllText(filePath, serializedPatientList);

        return true;
    }

}