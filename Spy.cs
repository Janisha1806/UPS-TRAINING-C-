public class Spy
{
    public static void Main(String[] args)
    {
        int product = 1;
        int sum = 0;
        Console.WriteLine("Enter the number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        while(n>0){
            int r = n %10;
            product*=r;
            sum+=r;
            n = n/10;
        }
        if(sum==product){
             Console.WriteLine("Spy number");   
        }
        else{
            Console.WriteLine("Not a spy number");
        }
        
    }
}