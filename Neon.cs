public class Neon
{
    public static void Main(String[] args)
    {
        int sum = 0;
        Console.WriteLine("Enter the number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int num =n * n;
        while(num>0){
            int r = num %10;
            sum+=r;
            num = num/10;
        }
        if(n==sum){
            Console.WriteLine("Neon number");

        }
        else{
            Console.WriteLine("Not a neon Number");
        }
    }
}