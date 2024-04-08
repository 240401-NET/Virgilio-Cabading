using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;

namespace VS_Tracking_App;

/// <summary>
///     Patient Class: 
///     Encapsulates the patient's biodata</para>
/// </summary>

public class Patient : IEquatable<Patient>
{
    // *** Fields ******

    private string _firstName;
    private string _lastName;
    private int _age;

    // *** Getters and Setters ******
    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    // *** Constructors ******

    /// <summary>
    /// Default Constructor
    /// </summary>
    public Patient()
    {
        _firstName = "";
        _lastName = "";
        _age = -1;
    }

    /// <summary>
    /// Parameterized Constructor
    /// </summary>
    /// <param name="newFirstName">The User's First Name in string format</param>
    /// <param name="newLastName">The User's Last Name in string format</param>
    /// <param name="newAge">The User's Age in integer format</param>
    public Patient(string newFirstName, string newLastName, int newAge)
    {
        _firstName = newFirstName;
        _lastName = newLastName;
        _age = newAge;
    }

    // *** Methods ******

    public bool IsDefault()
    {
        if (this.FirstName == "" && this.LastName == "")
        {
            return true;
        }
        return false;
    }

    /// <summary>
    /// Converts Patient class into a printble format
    /// </summary>
    /// <returns>string format of Patient class</returns>
    public override string ToString()
    {
        return $".::: Patient :: First Name: {_firstName}" +
                $" | Last Name: {_lastName}" +
                $" | Age: {_age} :::.";
    }

    // *** IEquatable Overriden Methods ******

    // Instance Method - IEquatable.Equals
    public bool Equals(Patient other)
    {
        // Edge case, other patient does not exist
        if (other == null)
        {
            return false;
        }

        // Two patients are equal if their first name and last name (in lowercase letters) are the same
        if ((this.FirstName.ToLower().Equals(other.FirstName.ToLower())) &&
            (this.LastName.ToLower().Equals(other.LastName.ToLower())))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Overridding - System.Object.Equals
    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
            return false;
        }

        Patient otherPatient = obj as Patient;
        if (otherPatient == null)
        {
            return false;
        }
        return this.Equals(otherPatient);
    }

    // Overrridding - System.Object.GetHashCode
    public override int GetHashCode()
    {
        return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode(); 
    }

    // Overloading - Equality
    public static bool operator ==(Patient patient1, Patient patient2)
    {
        if (((object)patient1 == null) && ((object)patient2 == null))
        {
            return true;
        }
        else if (((object)patient1 == null) || ((object)patient2 == null))
        {
            return false;
        }
        return patient1.Equals(patient2);
    }

    // Overloading - InEquality
    public static bool operator !=(Patient patient1, Patient patient2)
    {
        return !(patient1 == patient2);
    }
}