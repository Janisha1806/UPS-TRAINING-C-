public class Trigonometry
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the angle in degrees: ");
        double angle = Convert.ToDouble(Console.ReadLine());
        double radians = angle * Math.PI / 180;
        Console.WriteLine("Sin: "+Math.Sin(radians));
        Console.WriteLine("Cos: "+Math.Cos(radians));
        Console.WriteLine("Tan: "+Math.Tan(radians));
    }
}