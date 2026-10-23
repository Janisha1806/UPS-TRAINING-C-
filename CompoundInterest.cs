public class CompoundInterest {
  public static void Main() {
    Console.WriteLine("Enter the principal: ");
    double p = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the rate: ");
    double r = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the time in years: ");
    int time = Convert.ToInt32(Console.ReadLine());
    double ci = p * Math.Pow(1 + r / 100, time) - p;
    Console.WriteLine("The compound interest is: "+ci);
  }
}