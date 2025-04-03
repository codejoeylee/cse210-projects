public class ReflectingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time you overcame a challenge.",
        "Recall a moment you felt truly happy.",
        "Describe a moment when you helped someone in need.",
        "Think about a goal you accomplished that made you proud.",
        "Reflect on a time when you learned an important life lesson.",
        "Recall a moment when you felt deeply connected to someone.",
        "Think of a situation where you demonstrated resilience.",
        "Reflect on an experience that made you feel grateful."
    };

    public ReflectingActivity() : base(
        "Reflecting",
        "This activity helps you reflect on meaningful experiences.")
    { }

    private string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(prompts.Count);
        string selectedPrompt = prompts[index];
        prompts.RemoveAt(index);
        return selectedPrompt;
    }

    public void Run()
    {
        if (prompts.Count == 0)
        {
            Console.WriteLine("No more prompts available for reflection. Please restart the program.");
            return;
        }

        PromptForDuration();
        DisplayStartingMessage();


        Console.WriteLine($"Reflection prompt: {GetRandomPrompt()}");
        ShowSpinner(_duration);

        Console.WriteLine("When you are ready, type 'start' to continue.");
        string input;
        while ((input = Console.ReadLine()?.Trim().ToLower()) != "start")
        {
            Console.WriteLine("Please type 'start' to continue.");
        }

        Console.WriteLine("Now ponder on each of the following questions.");
        for (int i = 0; i < 2 && prompts.Count > 0; i++)
        {
            Console.WriteLine($"Reflection prompt: {GetRandomPrompt()}");
            ShowSpinner(_duration);
        }

        DisplayEndingMessage();
    }
}