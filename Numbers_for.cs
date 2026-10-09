public class Numbers_for
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter your initial value and ending value: ");
        int initial_v = Convert.ToInt32(Console.ReadLine());
        int final_v = Convert.ToInt32(Console.ReadLine());
        if(initial_v < final_v)
        {
           for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            } 
        }
        else if(initial_v > final_v)
        {
            for(int i = 10; i>=1; i--)
            {
                Console.WriteLine(i);
            }
    
        }
    }
}