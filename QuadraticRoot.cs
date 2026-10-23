

public class QuadraticRoots
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter b:");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter c:");
        double c = Convert.ToDouble(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("Not a quadratic equation");
        }
        else
        {
            double d = b * b - 4 * a * c;
            if (d > 0)
            {
                double r1 = (-b + Math.Sqrt(d)) / (2 * a);
                double r2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Root 1 = " + r1);
                Console.WriteLine("Root 2 = " + r2);
            }
            else if (d == 0)
            {
                double r = -b / (2 * a);
                Console.WriteLine("Equal roots = " + r);
            }
            else
            {
                double real = -b / (2 * a);
                double imaginary = Math.Sqrt(-d) / Math.Abs(2 * a);
                Console.WriteLine("Root 1 = " + real + " + " + imaginary + "i");
                Console.WriteLine("Root 2 = " + real + " - " + imaginary + "i");
            }
        }
    }
}