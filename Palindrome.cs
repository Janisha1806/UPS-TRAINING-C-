public class Paindrome
{
    public static void Main(String[] args)
    {
        int sum = 0;
        Console.WriteLine("Enter the number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int num = n;
        while(n>0){
            int r = n %10;
            sum = sum * 10 + r;
            n = n/10;
        }
        if(num == sum){
            Console.WriteLine("Palindrome");
        }
        else{
            Console.WriteLine("Not a palindrome");
        }
    }
}