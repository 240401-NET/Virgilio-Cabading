namespace VS_Tracking_App;

/// <summary>
///     Vital Signs Tracking Application
/// </summary>

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("//////////////////////////////////////////");
        Console.WriteLine("Vital Signs Tracking Application");
        Console.WriteLine("//////////////////////////////////////////\n");


        // *** TEST AREA ******

        Test appTester = new();

        // Test the User Class Methods
        appTester.TestUserClass();
    }
}
