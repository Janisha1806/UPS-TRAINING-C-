class Pow {
  static void Main() {
    Console.WriteLine("Enter the base number and exponent power: ");
    int base_no = Convert.ToInt32(Console.ReadLine());
    int pow = Convert.ToInt32(Console.ReadLine());
    double ans = Math.Pow(base_no,pow);
    Console.WriteLine(base_no+" ^ "+pow+" = "+ans);
  }
}