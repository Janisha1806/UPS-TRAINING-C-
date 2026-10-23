public class Absolute {
  public static void Main() {
    Console.WriteLine("Enter the number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int ans = Math.Abs(num);
    Console.WriteLine(ans);
  }
}