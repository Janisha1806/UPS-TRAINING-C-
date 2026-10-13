public class Rev_right_tri
{
    public static void Main(string[] args)
    {
        for (int i = 4; i >= 1; i--)
        {
            for (int k = 4; k > i; k--)
            {
                Console.Write("_");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }

            Console.WriteLine();
        }
    }
}