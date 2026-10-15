public class Armstrong
{
    public static void Main(String[] args)
    {
        int cube = 1;
        int sum = 0;
        //int count = 0;
        Console.WriteLine("Enter the number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int num = n;
        while(n>0){
            int r = n %10;
            cube = r*r*r;
            sum+=cube;
            //count++;
            n = n/10;
        }
        if(sum==num){
            Console.WriteLine("Armstrong number");
        }
        else{
            Console.WriteLine("Not an Armstrong number");

        }
        
    }
}
