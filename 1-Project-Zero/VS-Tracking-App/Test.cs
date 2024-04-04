namespace VS_Tracking_App;

/// <summary>
///     Test Class:
///         tests classes and methods used in Vital Sign Tracking Project
/// </summary>

class Test
{
    /// <summary>
    ///     Tests the User Class methods
    /// </summary>
    public void TestUserClass() {

        Console.WriteLine("---------------------");
        Console.WriteLine("Testing User Class methods\n");

        // Test Constructor
        Console.WriteLine("Create first user using parameterized constructor");
        User firstUser = new("Leonardo", "Turtle", 16);
        Console.WriteLine(firstUser.ToString());
        
        // Test Default Constructor
        Console.WriteLine("\nCreate second user using default constructor");
        User secondUser = new();
        Console.WriteLine(secondUser.ToString());

        // Test User Class Getters
        // Change the information for the user created via default constructor
        Console.WriteLine("\nTest User Getters and Setters, second user is now:");
        secondUser.FirstName = "Raphael";
        secondUser.LastName = "Turtle";
        secondUser.Age = 17;
        Console.WriteLine($"First name: {secondUser.FirstName}");
        Console.WriteLine($"Last name: {secondUser.LastName}");
        Console.WriteLine($"Age: {secondUser.Age}");

        Console.WriteLine("");
    }
}