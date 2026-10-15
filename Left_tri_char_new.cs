
public class Left_tri_char_new
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write((char)('A' + i + j - 2) + " ");
            }
            Console.WriteLine();
        }
    }
}
