public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing",
        "This activity helps you relax by focusing on your breathing.")
    { }

    public override void DisplayStartingMessage()
    {
        base.DisplayStartingMessage();
        Console.WriteLine("Get ready to breathe deeply...");
    }

    public void Run()
    {
        PromptForDuration();
        DisplayStartingMessage();
        for (int i = 0; i < _duration / 10; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(5);
            Console.WriteLine("Breathe out...");
            ShowSpinner(5);
        }
        DisplayEndingMessage();
    }
}