using System;
using System.Reflection.Metadata;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write($"Please enter your name: ");
        string name = Convert.ToString(Console.ReadLine());
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write($"Please enter your favorite number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"Brother {name}, the square of your number is {square}");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);
    }
}