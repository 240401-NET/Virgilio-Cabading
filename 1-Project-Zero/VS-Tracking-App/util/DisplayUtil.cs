using System.Diagnostics;

namespace VS_Tracking_App;

/// <summary>
/// Utility Class to Display items to the Terminal
/// </summary>

class DisplayUtil
{
    /// <summary>
    /// Clears the terminal
    /// </summary>
    public static void ClearTerminal()
    {
        Console.Clear();
    }

    /// <summary>
    /// Outputs the Program Header to the terminal
    /// </summary>
    public static void DisplayProgramHeader()
    {
        Console.WriteLine("//////////////////////////////////////////");
        Console.WriteLine("Vital Signs Tracking Application");
        Console.WriteLine("       /\\	Vital Signs         ");
        Console.WriteLine("      /  \\	Tracking Application");
        Console.WriteLine("_/\\  /    \\  /\\_____________________");
        Console.WriteLine("   \\/      \\/                       ");
        Console.WriteLine("------------------------------------------\n");
    }

    /// <summary>
    /// Stops the progression of the terminal application until the user hits enter
    /// </summary>
    public static void HoldTerminal()
    {
        Console.WriteLine("------------------------------------------");
        Console.Write("Press ENTER to proceed: ");
        Console.ReadLine();
    }
}