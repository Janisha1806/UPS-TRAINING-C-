public class ExponentialGrowth
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter initial population:");
        double initial = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter growth rate in decimal:");
        double rate = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter number of years:");
        int years = Convert.ToInt32(Console.ReadLine());
        double ans = initial * Math.Exp(rate * years);
        Console.WriteLine("Final Population = " + ans);
    }
}