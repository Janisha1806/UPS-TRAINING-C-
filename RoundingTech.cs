public class RoundingTech
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the decimal number: ");
        double num = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Floor: "+Math.Floor(num));
        Console.WriteLine("Ceil: "+Math.Ceiling(num));
        Console.WriteLine("Round: "+Math.Round(num));
    }
}