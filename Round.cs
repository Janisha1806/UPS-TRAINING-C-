public class Round {
  public static void Main() {
    Console.WriteLine("Enter the number: ");
    double num = Convert.ToDouble(Console.ReadLine());
    double round = Math.Round(num);
    Console.WriteLine("The round is: "+round);
  }
}