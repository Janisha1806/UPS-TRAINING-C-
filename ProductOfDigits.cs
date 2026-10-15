public class ProductOfDigits
{
    public static void Main(String[] args)
    {
        int product = 1;
        Console.WriteLine("Enter the number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        while(n>0){
            int r = n %10;
            product*=r;
            n = n/10;
        }
        Console.WriteLine(product);
    }
}
