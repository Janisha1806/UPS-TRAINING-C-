public class Char_right_tri
{
    public static void Main(string[] args)
    {
        char ch = 'a';

        for (int i = 1; i <= 3; i++)
        {
            for (int k = 3; k > i; k--)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write(ch);
                ch++;
            }

            Console.WriteLine();
        }
    }
}