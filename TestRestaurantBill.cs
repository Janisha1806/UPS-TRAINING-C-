using System;

class RestaurantBill
{
    public void CalculateBill(double price1)
    {
        Console.WriteLine("Item 1: " + price1);
        Console.WriteLine("Total Amount: " + price1);
    }
    public void CalculateBill(double price1, double price2)
    {
        double total = price1 + price2;
        Console.WriteLine("Item 1: " + price1);
        Console.WriteLine("Item 2: " + price2);
        Console.WriteLine("Total Amount: " + total);
    }
    public void CalculateBill(double[] prices)
    {
        double total = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            Console.WriteLine("Item " + (i + 1) + prices[i]);
            total += prices[i];
        }
        Console.WriteLine("Total Amount: " + total);
    }
    public void CalculateBill(double[] prices, double gst, double discount)
    {
        double total = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            total += prices[i];
        }
        double discountAmount = total * discount / 100;
        double subtotal = total - discountAmount;
        double gstAmount = subtotal * gst / 100;
        double finalBill = subtotal + gstAmount;
        if (finalBill > 2000)
        {
            finalBill -= 100;
        }
        Console.WriteLine("Subtotal: " + total);
        Console.WriteLine("Discount: " + discountAmount);
        Console.WriteLine("GST: " + gstAmount);
        Console.WriteLine("Final Bill: " + finalBill);
    }
}

class TestRestaurantBill
{
    static void Main()
    {
        RestaurantBill r = new RestaurantBill();
        r.CalculateBill(500, 300);
        Console.WriteLine();
        double[] prices = { 1000, 1000, 1000 };
        r.CalculateBill(prices, 10, 10);
    }
}