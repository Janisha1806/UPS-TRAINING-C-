class Calculator{
        public void Add(int a, int b){
            Console.WriteLine("Add: "+(a+b));
        }
        public void Sub(int a, int b){
            Console.WriteLine("Sub: "+(a-b));
        }
        public void Mul(int a, int b){
            Console.WriteLine("Mul: "+(a*b));
        }
        public void Div(int a, int b){
            Console.WriteLine("Div: "+(a/b));
        }
}
class CalC {
  static void Main() {
      try{
          Calculator obj = new Calculator();
            Console.WriteLine("Enter value 1: ");
            int v1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value 2: ");
            int v2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1 for Add, 2 for Sub, 3 for Mul, 4 for Div: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice){
                case 1:
                   obj.Add(v1,v2);
                   break;
                case 2:
                   obj.Sub(v1,v2);
                   break;
                case 3:
                   obj.Mul(v1,v2);
                   break;
                case 4:
                   obj.Div(v1,v2);
                   break;
            }
        }
        catch(DivideByZeroException e){
        Console.WriteLine("Please enter a non-zero divisor and try again.");
        }
        catch(FormatException e){
            Console.WriteLine("Please enter integer input values and try again.");
        }
    }
}