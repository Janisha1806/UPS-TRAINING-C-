public class SumProdCount
{
    public static void Main(String[] args)
    {
        int product = 1;
        int sum = 0;
        int count = 0;
        Console.WriteLine("Enter the number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        while(n>0){
            int r = n %10;
            product*=r;
            sum+=r;
            count++;
            n = n/10;
        }
        Console.WriteLine("Product: "+product);
        Console.WriteLine("Sum: "+sum);
        Console.WriteLine("Count: "+count);
    }
}