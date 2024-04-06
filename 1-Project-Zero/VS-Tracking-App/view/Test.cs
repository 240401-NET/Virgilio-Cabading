namespace VS_Tracking_App;

/// <summary>
///     Test Class:
///         tests classes and methods used in Vital Sign Tracking Project
/// </summary>
/// <remarks>Deprecated due to implementation of xUnit tests</remarks>

class Test
{
    /// <summary>
    ///     Tests the User Class methods
    /// </summary>
    public void TestUserClass() 
    {
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

        // Test User Class Getters and Setters
        //      Change the information for the user created via default constructor
        Console.WriteLine("\nTest User Getters and Setters, second user is now:");
        secondUser.FirstName = "Raphael";
        secondUser.LastName = "Turtle";
        secondUser.Age = 17;
        Console.WriteLine($"First name: {secondUser.FirstName}");
        Console.WriteLine($"Last name: {secondUser.LastName}");
        Console.WriteLine($"Age: {secondUser.Age}");

        Console.WriteLine("");
        DisplayUtil.HoldTerminal();
    }

    public void TestVitalSignClass()
    {
        Console.WriteLine("---------------------");
        Console.WriteLine("Testing Vital Sign Class methods\n");

        // Test Default Constructor and ToString method
        Console.WriteLine("*** Create a Default Vital Sign - (Expect BP -1/-1 HR -1)");
        Console.WriteLine("Testing: Default Constructor and ToString");
        VitalSign firstVS = new();
        Console.WriteLine(firstVS);
        Console.WriteLine("");

        // Test Parameterized Constructor
        Console.WriteLine("*** Create a Vital Sign - (Expect: BP 120/80 HR 75)");
        Console.WriteLine("Testing: Three param Constructor");
        VitalSign secondVS = new VitalSign(120, 80, 75);
        Console.WriteLine(secondVS);
        Console.WriteLine("");

        // Test Getters and Setters
        Console.WriteLine("*** Set defaulted Vital Sign to: BP 90/60 HR: 65");
        firstVS.SystolicBP = 90;
        firstVS.DiastolicBP = 60;
        firstVS.HeartRate = 65;
        Console.WriteLine(  $"Newly modified VS: Blood Pressure: {firstVS.SystolicBP}/{firstVS.DiastolicBP} " + 
                            $":: Heart Rate: {firstVS.HeartRate}");
        Console.WriteLine("");
        DisplayUtil.HoldTerminal();
    }
}