public class MinMax {
  public static void Main() {
    Console.WriteLine("Enter the number 1: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the number 2: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    int max = Math.Max(num1,num2);
    int min = Math.Min(num1,num2);
    Console.WriteLine("The maximumum is: "+max);
    Console.WriteLine("The minimumum is: "+min);
  }
}