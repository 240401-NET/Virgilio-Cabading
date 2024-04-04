namespace VS_Tracking_App;

/// <summary>
/// Vital Signs Tracking Application
/// </summary>

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("/////////////////////////////////");
        Console.WriteLine("Vital Signs Tracking Application");
        Console.WriteLine("/////////////////////////////////\n");

        // *** TEST AREA ******

        Console.WriteLine("Create first user using parameterized constructor");
        User firstUser = new("Leonardo", "Turtle", 16);
        Console.WriteLine(firstUser.ToString());
        
        Console.WriteLine("\nCreate second user using default constructor");
        User secondUser = new();
        Console.WriteLine(secondUser.ToString());
    }
}
