public class Strong
{
    public static void Main(String[] args)
    {
        int sum = 0;
        Console.WriteLine("Enter the number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int num = n;
        while(n>0){
            int r = n %10;
            int fact = 1;
            for(int i = 1; i <= r; i++)
            {
                fact *= i;
                
            }
            sum+=fact;
            n = n/10;
        }
        if(sum==num){
            Console.WriteLine("Strong number");
        }
        else{
            Console.WriteLine("Not a Strong number");

        }
        
    }
}

