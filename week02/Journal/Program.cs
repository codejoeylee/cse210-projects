/*
Showing Creativity and Exceeding Requirements:
I used JSON for storing and loading journal entries, which can be found in journal.cs.
Although JSON can serialize both properties and fields, it has certain rules that fields must follow regarding naming conventions.

Initially, I used fields like _date, _promptText, and _entryText, but encountered errors in the SaveToFile and LoadFromFile methods in journal.cs. When I saved a journal, it only saved an empty JSON.

After some research, I discovered that JSON strings must adhere to certain standards (e.g., "/\- \" )" is not a valid JSON string). To resolve this, I changed the entry fields to Date, PromptText, and EntryText.

This ensures proper serialization and deserialization, allowing for successful saving and loading of journal entries.
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("> ");
                    string response = Console.ReadLine();
                    Entry newEntry = new Entry(prompt, response);
                    journal.AddEntry(newEntry);
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case "4":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}