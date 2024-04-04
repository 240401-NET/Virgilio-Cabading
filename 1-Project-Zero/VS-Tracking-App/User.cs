using System.Collections.Specialized;

namespace VS_Tracking_App;

/// <summary>
///     User Class: 
///     Encapsulates the user's biodata</para>
/// </summary>

class User
{
    // *** Fields ******

    private string _firstName;
    public string _lastName;
    public int _age;

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

    public User()
    {
        _firstName = "unknown";
        _lastName = "unknown";
        _age = -1;
    }

    public User( string newFirstName, string newLastName, int newAge)
    {
        _firstName = newFirstName;
        _lastName = newLastName;
        _age = newAge;
    }

    // *** Methods ******

    public override string ToString()
    {
        return  $".::: User :: First Name: {_firstName}" +
                $" | Last Name: {_lastName}" +
                $" | Age: {_age} :::.";
    }
}