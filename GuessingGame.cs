
using System;

class Program
{
    static void Main()
    {
        Random r = new Random();
        string choice = "yes";

        while (choice == "yes")
        {
            int number = r.Next(1, 101);
            int guess, attempts = 0, score = 0;

            Console.WriteLine("Guess a number between 1 and 100");

            while (attempts < 5)
            {
                Console.Write("Enter your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
                attempts++;

                if (guess == number)
                {
                    Console.WriteLine("Correct Guess!");
                    score = (6 - attempts) * 20;
                    break;
                }
                else if (guess > number)
                    Console.WriteLine("Too High!");
                else
                    Console.WriteLine("Too Low!");
            }

            Console.WriteLine("Secret Number: " + number);
            Console.WriteLine("Attempts Used: " + attempts);
            Console.WriteLine("Score: " + score);

            Console.Write("Play again? (yes/no): ");
            choice = Console.ReadLine().ToLower();
        }
    }
}
