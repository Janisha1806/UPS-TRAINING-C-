public class Range_prime
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int k = 2; k <= n; k++)
        {
            int count = 0;

            for (int i = 1; i <= k; i++)
            {
                if (k % i == 0)
                {
                    count++;
                }
            }

            if (count == 2)
            {
                Console.Write(k + " ");
            }
        }
    }
}