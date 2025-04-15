namespace Exercise_Tracker;

public class Swimming : Activity
{
    protected int Laps { get; private set; }
    
    public Swimming(string date, int minutes, int laps):base(date, minutes)
    {this.Laps = laps;}

    public override double GetDistance()
    {
        return Laps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60;
    }

    public override double GetPace()
    {
        return Minutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Swimming - Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min/km";
    }
    
}