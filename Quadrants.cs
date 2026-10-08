public class Quadrants
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter your value of x quadrant: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your value of y quandrant: ");
        int y = Convert.ToInt32(Console.ReadLine());
        if(x>0 && y > 0)
        {
            Console.WriteLine("1st Quadrant");
        }
        else if(x>0 && y < 0)
        {
            Console.WriteLine("2nd Quadrant");
        }
        else if(x<0 && y < 0)
        {
            Console.WriteLine("3rd Quadrant");
        }
        else if( x<0 && y > 0)
        {
            Console.WriteLine("4th Quadrant");
        }
    }
}