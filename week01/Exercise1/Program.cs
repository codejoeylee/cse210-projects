using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name? ");
        string firstname = Convert.ToString(Console.ReadLine());

        Console.WriteLine("What is your last name? ");
        string lastname = Convert.ToString(Console.ReadLine());

        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");
    }
}