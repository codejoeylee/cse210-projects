namespace Exercise_Tracker;

public abstract class Activity(string date, int minutes)
{
    protected string Date { get; private set; } = date;
    protected int Minutes { get; private set; } = minutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{Date}  ({Minutes} min)";
    }

}