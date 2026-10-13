public class Multiplication
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the table that you want to print: ");
        int table = Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i <= 10; i++)
        {
            int ans = i*table;
            Console.WriteLine(i+"x"+table+ "="+ans);
        }
    }
}