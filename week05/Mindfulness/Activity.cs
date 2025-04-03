public class Activity
{
    private string _name { get; set; }
    private string _description { get; set; }
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public virtual void DisplayStartingMessage()
    {
        Console.WriteLine($"Name: {_name} Activity");
        Console.WriteLine(_description);
        Console.WriteLine($"Duration: {_duration} seconds");
    }

    public virtual void DisplayEndingMessage()
    {
        Console.WriteLine($"Ending {_name} Activity.");
    }

    public void ShowSpinner(int seconds)
    {
        Console.Write("Loading");
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void PromptForDuration()
    {
        Console.Write("Enter the duration for this activity (in seconds): ");
        _duration = int.Parse(Console.ReadLine());
    }
}

