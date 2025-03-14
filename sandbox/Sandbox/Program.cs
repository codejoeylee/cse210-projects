using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(string prompt, string response)
    {
        Entry entry = new Entry(prompt, response);
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.GetPrompt()}|{entry.GetResponse()}|{entry.GetDate()}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry entry = new Entry(parts[0], parts[1]);
                    entry.SetDate(parts[2]);
                    entries.Add(entry);
                }
            }
        }
    }
}

public class Entry
{
    public string prompt;
    public string response;
    public string date;

    public Entry(string prompt, string response)
    {
        this.prompt = prompt;
        this.response = response;
        this.date = DateTime.Now.ToString("yyyy-MM-dd");
    }

    public string GetPrompt()
    {
        return prompt;
    }

    public string GetResponse()
    {
        return response;
    }

    public string GetDate()
    {
        return date;
    }

    public void SetDate(string date)
    {
        this.date = date;
    }

    public override string ToString()
    {
        return $"{date} - {prompt}: {response}";
    }
}
public class Program
{
    public static Journal journal = new Journal();
    public static string[] prompts = new string[]
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    static void Main(string[] args)
    {
        {
            string option;
            do
            {
                Console.WriteLine("Journal Menu:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        WriteNewEntry();
                        break;
                    case "2":
                        journal.DisplayEntries();
                        break;
                    case "3":
                        SaveJournal();
                        break;
                    case "4":
                        LoadJournal();
                        break;
                }
            } while (option != "5");
        }
    }
    public static void WriteNewEntry()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        journal.AddEntry(prompt, response);
    }

    public static void SaveJournal()
    {
        Console.Write("Enter filename to save the journal: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
    }

    public static void LoadJournal()
    {
        Console.Write("Enter filename to load the journal: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);

    }
}