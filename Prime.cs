public class Prime
{
    public static void Main(String[] args)
    {
        int count = 0;
        Console.WriteLine("Enter the number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for(int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                count++;
            }
        }
        if (count > 0)
        {
            Console.WriteLine("It is not prime number");
            break;
        }
        else
        {
            Console.WriteLine("It is a composite number");
        }
    }
}