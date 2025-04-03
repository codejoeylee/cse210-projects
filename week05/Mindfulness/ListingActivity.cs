public class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "List all the things you're grateful for.",
        "List your favorite memories."
    };

    public ListingActivity() : base(
        "Listing",
        "This activity helps you focus by listing thoughts or ideas.")
    { }

    private string GetRandomPrompt()
    {
        var random = new Random();
        return prompts[random.Next(prompts.Count)];
    }

    public void Run()
    {
        PromptForDuration();
        DisplayStartingMessage();
        Console.WriteLine($"Listing prompt: {GetRandomPrompt()}");

        List<string> responses = new List<string>();
        Console.WriteLine("Type your responses below (type 'done' to finish):");

        string input;
        while ((input = Console.ReadLine()) != "done")
        {
            responses.Add(input);
        }

        Console.WriteLine("You listed the following:");
        foreach (var response in responses)
        {
            Console.WriteLine($"- {response}");
        }
        DisplayEndingMessage();
    }
}