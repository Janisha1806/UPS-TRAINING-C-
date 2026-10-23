public class Log
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a positive number: ");
        double n = Convert.ToDouble(Console.ReadLine());
        double natural_log= Math.Log(n);
        double log_10= Math.Log10(n);
        Console.WriteLine("Natual log: "+natural_log);
        Console.WriteLine("Log base 10: "+log_10);
    }
}