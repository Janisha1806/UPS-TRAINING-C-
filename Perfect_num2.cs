public class Perfect_num2
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
        else if(sum>n)
        {
            Console.WriteLine("Abundant number");
        }
        else
        {
            Console.WriteLine("Deficient number");
        }
    }
}
