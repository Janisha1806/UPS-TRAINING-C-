
using System;

abstract class FoodOrder
{
    public int Quantity;
    public abstract void CalculatePrice();
}
class PizzaOrder : FoodOrder
{
    public override void CalculatePrice()
    {
        CalculateBill("Pizza", 250);
    }
    public void CalculateBill(string food, int price)
    {
        int subtotal = price * Quantity;
        int discount;
        if (Quantity >= 5)
        {
            discount = subtotal * 10 / 100;
        }
        else
        {
            discount = 0;
        }
        int delivery = 30;
        int finalBill = subtotal - discount + delivery;
        Console.WriteLine("\nFood: " + food);
        Console.WriteLine("Quantity: " + Quantity);
        Console.WriteLine("Unit Price: " + price);
        Console.WriteLine("Subtotal: " + subtotal);
        Console.WriteLine("Discount: " + discount);
        Console.WriteLine("Delivery Charge: " + delivery);
        Console.WriteLine("Final Bill: " + finalBill);
    }
}
class BurgerOrder : FoodOrder
{
    public override void CalculatePrice()
    {
        PizzaOrder p = new PizzaOrder();
        p.Quantity = Quantity;
        p.CalculateBill("Burger", 120);
    }
}
class BiryaniOrder : FoodOrder
{
    public override void CalculatePrice()
    {
        PizzaOrder p = new PizzaOrder();
        p.Quantity = Quantity;
        p.CalculateBill("Biryani", 180);
    }
}
class TestAbstraction
{
    static void Main()
    {
        Console.Write("Enter Food (Pizza/Burger/Biryani): ");
        string food = Console.ReadLine().Trim().ToLower();
        Console.Write("Enter Quantity: ");
        int qty;
        qty = Convert.ToInt32(Console.ReadLine());
        if (qty <= 0)
        {
            Console.WriteLine("Invalid Quantity!");
            return;
        }
        FoodOrder order;
        switch (food)
        {
            case "pizza":
                order = new PizzaOrder();
                break;
            case "burger":
                order = new BurgerOrder();
                break;
            case "biryani":
                order = new BiryaniOrder();
                break;
            default:
                Console.WriteLine("Invalid Food Choice!");
                return;
        }
        order.Quantity = qty;
        order.CalculatePrice();
    }
}