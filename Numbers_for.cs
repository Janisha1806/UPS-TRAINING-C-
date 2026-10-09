public class Numbers_for
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter your initial value and ending value: ");
        int initial_v = Convert.ToInt32(Console.ReadLine());
        int final_v = Convert.ToInt32(Console.ReadLine());
        if(initial_v < final_v)
        {
           for(int i = initial_v; i <= final_v; i++)
            {
                Console.WriteLine(i);
            } 
        }
        else if(initial_v > final_v)
        {
            for(int i = initial_v; i >= final_v; i--)
            {
                Console.WriteLine(i);
            }
    
        }
    }
}