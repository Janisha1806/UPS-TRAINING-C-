public class Tri_condition
{
    public static void Main(String[] args)
    {
        for(int i = 2; i <= 8; i++)
        {
            for(int j=2; j <= i; j++)
            {
                if (j % 2 == 0)
                {
                   Console.Write("0"); 
                }
                else
                {
                    Console.Write("#"); 
                }
                
            }
            Console.WriteLine("");
        }
    }
}