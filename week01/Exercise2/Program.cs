using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade : ");
        int grade = Convert.ToInt32(Console.ReadLine());
        char yourGrade = 'F';
        string gradeSign = "";

        if (grade >= 0 && grade <= 100)
        {
            if (grade >= 90)
            {
                yourGrade = 'A';
            }
            else if (grade >= 80)
            {
                yourGrade = 'B';
            }
            else if (grade >= 70)
            {
                yourGrade = 'C';
            }
            else if (grade >= 60)
            {
                yourGrade = 'D';
            }

            int lastDigit = grade % 10;
            if (lastDigit >= 7)
            {
                gradeSign = "+";
            }
            else if (lastDigit < 3)
            {
                gradeSign = "-";
            }

            if (yourGrade == 'A' && gradeSign == "+")
            {
                gradeSign = "";
            }
            if (yourGrade == 'F')
            {
                gradeSign = "";
            }

            Console.WriteLine($"Your grade: {yourGrade}{gradeSign}");

            if (grade >= 70)
            {
                Console.WriteLine("You passed this course.\nKeep up the good work.");
            }
            else
            {
                Console.WriteLine("You failed this course.\nKeep studying, there is more room for improvement.");
            }
        }
        else
        {
            Console.WriteLine("Your grades can not be more than 100%");
        }
    }
}



