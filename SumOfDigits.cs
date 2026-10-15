public class SumOfDigits
{
    public static void Main(String[] args)
    {
        int sum = 0;
        Console.WriteLine("Enter the number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        while(n>0){
            int r = n %10;
            sum+=r;
            n = n/10;
        }
        Console.WriteLine(sum);
    }
}