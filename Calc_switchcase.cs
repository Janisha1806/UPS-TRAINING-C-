using System.Collections;
using System.Diagnostics;

public class Calc_switchcase
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter your variable1 : ");
        int var1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your variable2 : ");
        int var2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("From (Add,Sub,Mul,Div) Select your operation: ");
        String opp = Console.ReadLine();
        int ans ;
        switch (opp)
        {
            case "Add":
                ans = var1+var2;
                break;
            case "Sub":
                ans = var1-var2;
                break;
            case "Mul":
                ans = var1*var2;
                break;
            case "Div":
                if (var2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                    return;
                }
                ans = var1/var2;
                break;
            default:
                Console.WriteLine("Invalid operation. Choose Add, Sub, Mul, or Div.");
                return;
        }
        Console.WriteLine("Answer is "+ans);
    }
}