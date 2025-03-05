using System;

class Program
{
    static void Main(string[] args)
    {
        int yourGuess = 0;
        int randomNumber = 0;
        List<int> myList = new List<int>();
        string play = "yes";
        while (play == "yes")
        {
            do
            {
                Random random = new Random();
                randomNumber = random.Next(0, 3);
                Console.Write("What is your guess? ");
                yourGuess = Convert.ToInt32(Console.ReadLine());
                myList.Add(yourGuess);

                if (yourGuess == randomNumber)
                {
                    Console.WriteLine("you guessed it!");
                }
                else if (yourGuess < randomNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Lower");
                }

            } while (yourGuess != randomNumber);

            Console.WriteLine("Your Guesses : ");
            foreach (int Guess in myList)
            {
                Console.WriteLine(Guess);
            }

            Console.WriteLine("Do you want to play again: ");
            play = Convert.ToString(Console.ReadLine());
        }
    }
}