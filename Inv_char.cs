public class Inv_char
{
    public static void Main(String[] args)
    {
        for (int i = 3; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write((char)('a' + j - 1));
            }
            Console.WriteLine();
        }
    }
}

