using System;

public class Program
{
    private static void ClearConsole()
    {
        Console.Clear();
    }

    public static void Main(string[] args)
    {
        var reference = new Reference("Proverbs", 3, 5, 6);
        var scripture = new Scripture(reference, "Trust in the Lord with all your heart and lean not on your own understanding.");

        while (true)
        {
            ClearConsole();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit:");

            string userInput = Console.ReadLine()?.Trim().ToLower();
            if (userInput == "quit") break;

            scripture.HideRandomWords(2);

            if (scripture.IsCompletelyHidden())
            {
                ClearConsole();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Goodbye!");
                break;
            }
        }
    }
}