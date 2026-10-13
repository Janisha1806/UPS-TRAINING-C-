public class Right_tri
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 4; i++)
        {
            for (int k = 4; k > i; k--)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }

            Console.WriteLine();
        }
    }
}