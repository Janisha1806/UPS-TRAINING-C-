public class Range_perfect
{
    public static void Main(String[] args)
    {
        
        Console.WriteLine("Enter the number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for(int k = 1; k<=n;k++){
            int sum = 0;
            for(int i = 1; i < k; i++)
            {
                if (k % i == 0)
                {
                    sum += i;
                }
            }
            if (sum==k)
            {
                Console.WriteLine(k + " ");
            }
        }
    }
}
