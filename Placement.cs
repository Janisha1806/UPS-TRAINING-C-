public class Placement
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter your score in Aptitude round: ");
        int apti_score = Convert.ToInt32(Console.ReadLine());
        if (apti_score >= 70)
        {
            Console.WriteLine("Enter your score in Technical round: ");
            int tech_score = Convert.ToInt32(Console.ReadLine());
            if(tech_score >= 80)
            {
                Console.WriteLine("Enter your score in HR round: ");
                int hr_score = Convert.ToInt32(Console.ReadLine());
                if(hr_score >= 80)
                {
                    int score = apti_score + tech_score + hr_score;
                    if(score >= 280 && score <= 300)
                    {
                        Console.WriteLine("Your Salary is 25k per month");
                    }
                    else if(score >= 250 && score < 280)
                    {
                        Console.WriteLine("Your Salary is 20k per month");
                    }
                    else if(score >= 230 && score < 250)
                    {
                        Console.WriteLine("Your Salary is 15k per month");
                    }
                }
                else
                {
                    Console.WriteLine("You are not selected in HR round. Better luck next time");
                }
            }
            else
            {
                Console.WriteLine("You are not eligible for HR round. Better luck next time"); 
            }
        }
        else
        {
            Console.WriteLine("You are not eligible for Technical round. Better luck next time");
        }
    }
}