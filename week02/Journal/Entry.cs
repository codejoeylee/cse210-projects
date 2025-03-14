using System;

class Entry
{
    public string Date { get; set; }
    public string PromptText { get; set; }
    public string EntryText { get; set; }

    public Entry(string promptText, string entryText)
    {
        Date = DateTime.Now.ToString("MM/dd/yyyy");
        PromptText = promptText;
        EntryText = entryText;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {PromptText}");
        Console.WriteLine($"Entry: {EntryText}");
        Console.WriteLine();
    }
}