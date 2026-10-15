public class Perfect_num
{
    public static void Main(String[] args)
    {
        int sum = 0;
        Console.WriteLine("Enter the number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i < n; i++)
        {
            if (n % i == 0)
            {
                sum += i;
            }
        }
        if (sum==n)
        {
            Console.WriteLine("It is a perfect number");
        }
        else
        {
            Console.WriteLine("It is not a perfect number");
        }
    }
}
