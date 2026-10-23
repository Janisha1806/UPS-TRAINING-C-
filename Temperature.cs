public class Temperature{
  public static void Main() {
    Console.WriteLine("Enter the temperature in celsius: ");
    double celsius = Convert.ToDouble(Console.ReadLine());
    double fahrenheit =  Math.Round((celsius * 9.0 / 5) + 32, 2);
    Console.WriteLine("The temperature in fahrenheit: "+fahrenheit);
  }
}