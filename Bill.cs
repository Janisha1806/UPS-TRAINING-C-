public class Bill
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter your item name: ");
        String item = Console.ReadLine();
        Console.WriteLine("Enter the quantity: ");
        int quantity = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the price per unit: ");
        float price = Convert.ToSingle(Console.ReadLine());
        float bill = quantity * price;
        float discount = 0;
        if (bill > 5000)
        {
             discount = bill * 0.18f;
        }
        float gst = bill * 0.12f;
        float total_bill = (bill - discount) + gst;
        Console.WriteLine("Your total bill is "+total_bill);
    }
}