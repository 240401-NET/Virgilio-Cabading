using System.Collections.Specialized;

namespace VS_Tracking_App;

/// <summary>
///     User Class: 
///     Encapsulates the user's biodata</para>
/// </summary>

public class User
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
    public User()
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
    public User( string newFirstName, string newLastName, int newAge)
    {
        _firstName = newFirstName;
        _lastName = newLastName;
        _age = newAge;
    }

    // *** Methods ******

    /// <summary>
    /// Converts User class into a printble format
    /// </summary>
    /// <returns>string format of user class</returns>
    public override string ToString()
    {
        return  $".::: User :: First Name: {_firstName}" +
                $" | Last Name: {_lastName}" +
                $" | Age: {_age} :::.";
    }
}