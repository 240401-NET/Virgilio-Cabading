namespace VS_Tracking_App;

/// <summary>
/// User Class
/// </summary>

class User
{
    // *** Fields ******

    public string firstName { get; set; }
    public string lastName { get; set; }
    public int age { get; set; }

    // *** Constructors ******

    public User()
    {
        firstName = "unknown";
        lastName = "unknown";
        age = -1;
    }

    public User( string newFirstName, string newLastName, int newAge)
    {
        this.firstName = newFirstName;
        this.lastName = newLastName;
        this.age = newAge;
    }

    // *** Methods ******

    public override string ToString()
    {
        return  $".::: User :: First Name: {firstName}" +
                $" | Last Name: {lastName}" +
                $" | Age: {age} :::.";
    }
}