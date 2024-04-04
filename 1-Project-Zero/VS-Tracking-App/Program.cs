namespace VS_Tracking_App;

/// <summary>
///     Vital Signs Tracking Application
/// </summary>

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("/////////////////////////////////");
        Console.WriteLine("Vital Signs Tracking Application\n");


        // *** TEST AREA ******

        Test appTester = new();

        // Test the User Class Methods
        appTester.TestUserClass();
    }
}
