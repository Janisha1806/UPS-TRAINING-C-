public class Odd_1_100
{
     public static void Main(String[] args)
    {
        for(int i = 2; i < 100; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}