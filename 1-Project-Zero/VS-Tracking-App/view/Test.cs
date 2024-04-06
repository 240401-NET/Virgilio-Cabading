namespace VS_Tracking_App;

/// <summary>
///     Test Class:
///         tests classes and methods used in Vital Sign Tracking Project
/// </summary>
/// <remarks>Deprecated due to implementation of xUnit tests</remarks>

class Test
{
    /// <summary>
    ///     Tests the Patient Class methods
    /// </summary>
    public void TestPatientClass() 
    {
        Console.WriteLine("---------------------");
        Console.WriteLine("Testing Patient Class methods\n");

        // Test Constructor
        Console.WriteLine("Create first Patient using parameterized constructor");
        Patient firstPatient = new("Leonardo", "Turtle", 16);
        Console.WriteLine(firstPatient.ToString());
        
        // Test Default Constructor
        Console.WriteLine("\nCreate second Patient using default constructor");
        Patient secondPatient = new();
        Console.WriteLine(secondPatient.ToString());

        // Test Patient Class Getters and Setters
        //      Change the information for the Patient created via default constructor
        Console.WriteLine("\nTest Patient Getters and Setters, second Patient is now:");
        secondPatient.FirstName = "Raphael";
        secondPatient.LastName = "Turtle";
        secondPatient.Age = 17;
        Console.WriteLine($"First name: {secondPatient.FirstName}");
        Console.WriteLine($"Last name: {secondPatient.LastName}");
        Console.WriteLine($"Age: {secondPatient.Age}");

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