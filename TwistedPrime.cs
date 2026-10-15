public class TwistedPrime
{
    public static void Main(String[] args)
    {
        int count = 0;
        Console.WriteLine("Enter a prime number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum =0;
        while(n>0)
        {
            int r = n %10;
            sum = sum * 10 + r;
            n = n/10;
        }
        for(int i = 2; i < sum; i++)
        {
            if (sum % i == 0)
            {
                count++;
                break;
            }
        }
        if (count > 0)
        {
            Console.WriteLine("It is not twisted prime number");
        }
        else
        {
            Console.WriteLine("It is a twisted prime number");
        }
    }
}