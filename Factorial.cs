using System.Net.NetworkInformation;

public class Factorial
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the number for which you want to print the factorial: ");
        int fact = Convert.ToInt32(Console.ReadLine());
        int mul = 1;
        for(int i = 1; i <= fact; i++)
        {
            mul *= i;
        }
        Console.WriteLine(mul);
    }
}