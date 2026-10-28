class ElectricityBill {
  static void Main() {
    Console.WriteLine("Enter the number of customers: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int id;
    int units=1;
    int charge=1;
    string name;
    int fixedcharge = 50;
    double revenue=0;
    int count = 0;
    for(int i=0;i<number;i++){
        Console.WriteLine("Enter the name of customer: ");
        name = Console.ReadLine();
        Console.WriteLine("Enter the ID of customer: ");
        id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the amount of units consumed: ");
        units = Convert.ToInt32(Console.ReadLine());
        if(units>0 && units<=100){
            charge = units*2;
        }
        else if(units>100 && units<=200){
            charge = units*3;
        }
        else if(units>200){
            charge = units*5;
        }
        int bill = fixedcharge+charge;
        Console.WriteLine("Customer Name: "+name);
        Console.WriteLine("Customer ID: "+id);
        Console.WriteLine("Units Consumed: "+units);
        Console.WriteLine("Bill: "+bill);
        if(bill<250){
            Console.WriteLine("Low power consumption");
        }
        else{
            Console.WriteLine("High power consumption");
        }
        revenue += bill;
        count++;
    }
    Console.WriteLine("Total number of revenue: "+revenue);
    Console.WriteLine("Customers Processed: "+count);
  }
}