public class Automorphic
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());
        int sq = num * num;
        int temp = num;
        int div = 1;
        while (temp > 0)
        {
            div *= 10;
            temp /= 10;
        }
        if (num >= 0 && sq % div == num)
            Console.WriteLine("Automorphic number");
        else
            Console.WriteLine("Not an Automorphic number");
    }
}