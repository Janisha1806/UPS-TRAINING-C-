public class Sum_count
{
    public static void Main(String[] args)
    {
        int sum = 0;
        int count = 0;
        for(int i = 1; i <= 10; i++)
        {
            sum += i;
            count++;
        }
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Count: " + count);
    }
}