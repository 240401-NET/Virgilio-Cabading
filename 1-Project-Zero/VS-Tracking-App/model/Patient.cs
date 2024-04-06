using System.Collections.Specialized;

namespace VS_Tracking_App;

/// <summary>
///     Patient Class: 
///     Encapsulates the patient's biodata</para>
/// </summary>

public class Patient
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
    public Patient ()
    {
        _firstName = "unknown";
        _lastName = "unknown";
        _age = -1;
    }

    /// <summary>
    /// Parameterized Constructor
    /// </summary>
    /// <param name="newFirstName">The User's First Name in string format</param>
    /// <param name="newLastName">The User's Last Name in string format</param>
    /// <param name="newAge">The User's Age in integer format</param>
    public Patient( string newFirstName, string newLastName, int newAge)
    {
        _firstName = newFirstName;
        _lastName = newLastName;
        _age = newAge;
    }

    // *** Methods ******

    /// <summary>
    /// Converts Patient class into a printble format
    /// </summary>
    /// <returns>string format of Patient class</returns>
    public override string ToString()
    {
        return  $".::: Patient :: First Name: {_firstName}" +
                $" | Last Name: {_lastName}" +
                $" | Age: {_age} :::.";
    }
}