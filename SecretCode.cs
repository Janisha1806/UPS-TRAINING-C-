class SecretCode
{
    static void Main()
    {
        Random r = new Random();
        string choice = "yes";
        while (choice == "yes")
        {
            int secret = r.Next(1000, 10000);
            int attempts = 0, score = 0;
            while (attempts < 10)
            {
                Console.WriteLine("Guess the 4 digit number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number < 1000 || number > 9999)
                {
                    Console.WriteLine("Enter a valid 4 digit number");
                    continue;
                }
                attempts++;
                int correct = 0;
                string s = secret.ToString();
                string n = number.ToString();
                for (int i = 0; i < 4; i++)
                {
                    if (s[i] == n[i])
                    {
                        correct++;
                    }
                }
                Console.WriteLine("Correct digits in position: " + correct);
                Console.WriteLine("Remaining attempts: " + (10 - attempts));
                if (number == secret)
                {
                    Console.WriteLine("You cracked the code!");
                    score = (11 - attempts) * 10;
                    break;
                }
            }
            if (attempts == 10 && score == 0)
            {
                Console.WriteLine("Game Over!");
            }
            Console.WriteLine("Secret Code: " + secret);
            Console.WriteLine("Your Score: " + score);
            Console.WriteLine("Do you want to play again? (yes/no)");
            choice = Console.ReadLine().ToLower();
        }
    }
}