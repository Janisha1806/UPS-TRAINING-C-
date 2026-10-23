public class BMI {
  public static void Main() {
    Console.WriteLine("Enter the weight in kg: ");
    double w = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the height in metres: ");
    double h = Convert.ToDouble(Console.ReadLine());
    double bmi = w / Math.Pow(h,2);
    Console.WriteLine("The BMI is: "+bmi);
  }
}