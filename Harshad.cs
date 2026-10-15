public class Harshad
{
    public static void Main(String[] args)
    {
        int sum = 0;
        Console.WriteLine("Enter the number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int num =n;
        while(n>0){
            int r = n %10;
            sum+=r;
            n = n/10;
        }
        if(num%sum ==0){
            Console.WriteLine("Harshad number");

        }
        else{
            Console.WriteLine("Not a Harshad Number");
        }
    }
}