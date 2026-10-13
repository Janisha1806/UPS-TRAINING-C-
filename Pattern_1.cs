public class Pattern_1
{
    public static void Main(string[] args)
    {
        for (int i = 9; i >= 1; i -= 2)
        {
            if (i == 3)
                continue;

            for (int j = 1; j <= i; j += 2)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}