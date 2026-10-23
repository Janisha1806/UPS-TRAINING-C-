public class CircleArea
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        double radius = random.Next(1, 10);
        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine("Radius = " + radius);
        Console.WriteLine("Circle Area = " +Math.Round(area, 2));
    }
}