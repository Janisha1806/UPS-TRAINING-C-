public class Pattern_2
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 9; j >= 11 - 2 * i; j -= 2)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}