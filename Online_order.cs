public class Online_order
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Available Products :Watch(Rs. 5000), Stationery(Rs. 3000), Dress(Rs. 8000)");
        Console.WriteLine("Enter the product name:");
        string product_name = Console.ReadLine();
        if(product_name == "Watch" || product_name == "Stationery" || product_name == "Dress")
        {        
            Console.WriteLine("Enter the quantity:");
            int quantity = Convert.ToInt32(Console.ReadLine());
            int total_price = 0;
            if(product_name == "Watch")
            {
                int price = 5000;
                total_price = price * quantity;
                String coupon_code = "wat001";
                Console.WriteLine("Enter the coupon code:");
                String entered_coupon_code = Console.ReadLine();
                if(entered_coupon_code == coupon_code)
                {
                    float discount = 0.15f;
                    total_price = (int)(total_price - (total_price * discount));
                }
                else if(entered_coupon_code != coupon_code)
                {
                    Console.WriteLine("Invalid coupon code. No discount applied.");
                }
            }
            else if(product_name == "Stationery")
            {
                int price = 3000;
                total_price = price * quantity;
                String coupon_code = "sta002";
                Console.WriteLine("Enter the coupon code:");
                String entered_coupon_code = Console.ReadLine();
                if(entered_coupon_code == coupon_code)
                {
                    float discount = 0.10f;
                    total_price = (int)(total_price - (total_price * discount));
                }
                else if(entered_coupon_code != coupon_code)
                {
                    Console.WriteLine("Invalid coupon code. No discount applied.");
                }
            }
            else if(product_name == "Dress")
            {
                int price = 8000;
                total_price = price * quantity;
                String coupon_code = "dre003";
                Console.WriteLine("Enter the coupon code:");
                String entered_coupon_code = Console.ReadLine();
                if(entered_coupon_code == coupon_code)
                {
                    float discount = 0.20f;
                    total_price = (int)(total_price - (total_price * discount));
                }
                else if(entered_coupon_code != coupon_code)
                {
                    Console.WriteLine("Invalid coupon code. No discount applied.");
                }
            }
             int shipping_charge = 350;
            int total_amount = total_price + shipping_charge;
            Console.WriteLine("Total amount to be paid: Rs." + total_amount);
            Console.WriteLine("Enter your payment method: Only GPay, PhonePe are accepted");
            string payment_method = Console.ReadLine();
            if(payment_method == "GPay" || payment_method == "PhonePe")
            {
                Console.WriteLine("Payment successful. Thank you for your order!");
            }
            else
            {
                Console.WriteLine("Invalid payment method. Please try again with correct payment method.");
            }
        }
        else
        {
            Console.WriteLine("Invalid product name. Please try again with correct product name.");
        }
    }
}
