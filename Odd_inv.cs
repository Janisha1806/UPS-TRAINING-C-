public class Odd_inv
{
    public static void Main(String[] args)
    {
        for(int i = 5; i >= 1; i--)
        {
            for(int j=1; j <=i ; j++)
            {
                    Console.Write(2*j-1);

            }
            Console.WriteLine("");
        }
    }
}

