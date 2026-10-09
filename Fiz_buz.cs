public class Fix_buz
{
    public static void Main(String[] args)
    {
        for (int i = 1; i <= 15; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine(i + "FIZ_BUZ");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine(i + "Fiz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine(i + "Buz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}