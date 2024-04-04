namespace VS_Tracking_App;

public class VitalSign
{
    // *** Fields *******
    private int _heartRate;

    // Systolic BLood Pressure
    private int _systolicBP;

    // Diastolic Blood Pressure
    private int _diastolicBP;

    // TODO Create a variable for Date Time

    // *** Getters and Setters ******

    public int HeartRate
    {
        get { return _heartRate; }
        set { _heartRate = value; }
    }

    public int SystolicBP
    {
        get { return _systolicBP; }
        set { _systolicBP = value; }
    }

    public int DiastolicBP
    {
        get { return _diastolicBP; }
        set { _diastolicBP = value; }
    }

    // *** Constructors ******

    /// <summary>
    /// Default Constructor
    /// </summary>
    public VitalSign()
    {
        _heartRate = -1;
        _systolicBP = -0;
        _diastolicBP = -1;
    }

    /// <summary>
    /// Three parameter constructor
    /// </summary>
    /// <param name="newSystolicBP">The patient's Systolic Blood Pressure as an integer</param>
    /// <param name="newDiastolicBP">The patient's Diastolic Blood Prewssure as an integer</param>
    /// <param name="newHeartRate">The patient's Heart Rate as an integer</param>
    public VitalSign(int newSystolicBP, int newDiastolicBP, int newHeartRate)
    {
        _systolicBP = newSystolicBP;
        _diastolicBP = newDiastolicBP;
        _heartRate = newHeartRate;
    }

    // *** Methods ******

    /// <summary>
    /// Converts Vital Sign Class into a printable format
    /// </summary>
    /// <returns>string format of a Vital Sign Class</returns>
    public override string ToString()
    {
        return base.ToString();
    }
}