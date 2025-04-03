using System;
using System.Collections.Generic;


/// <summary>
/// Showing Creativity : ReflectingActivity
/// I ensured that prompts are displayed without duplication by removing each selected prompt from the list. 
// Additionally, it limits the number of prompts displayed to less than three, preventing overly lengthy sections and keeping the engaging.
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        bool keepRunning = true;
        while (keepRunning)
        {
            Console.WriteLine("\nWelcome to the Mindfulness Program!");
            Console.WriteLine("Please select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;

                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;

                case "4":
                    Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                    keepRunning = false;
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }
        }
    }
}