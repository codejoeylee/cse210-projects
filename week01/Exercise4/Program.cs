using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 to when finished.");
        do
        {
            Console.Write("Enter a number : ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        int sum = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
        }

        Console.WriteLine($"The sum is: {sum}");
        double average = numbers.Average();
        Console.WriteLine($"The Average is : {average}");

        int largest = numbers.Max();
        Console.WriteLine($"The largert number is : {largest}");

        int smallestPositive = int.MaxValue;
        foreach (int num in numbers)
        {
            if (num > 0 && num < smallestPositive)
            {
                smallestPositive = num;
            }
        }

        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive numbers is : {smallestPositive}");
        }


        numbers.Sort();
        Console.WriteLine("The sorted list is :");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}