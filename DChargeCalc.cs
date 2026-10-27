public class DeliveryService
{
    public void CalculateDeliveryCharge(double dist1)
    {
        Console.WriteLine("Distance: "+dist1+" Delivery charge: "+(dist1*100));
    }
    public void CalculateDeliveryCharge(double dist2, double weight)
    {
        Console.WriteLine("Distance: "+dist2+" Weight: "+weight+" Delivery charge: "+(dist2*100));
    }
    public void CalculateDeliveryCharge(double dist3, double weight2,string status)
    {
        Console.WriteLine("Distance: "+dist3+" Weight: "+weight2+" Delivery charge: "+(dist3*100)+" Delivery-status: "+status);
    }
}
public class DChargeCalc
{
    public static void Main(string[] args)
    {
        DeliveryService obj = new DeliveryService();
        obj.CalculateDeliveryCharge(20);
        obj.CalculateDeliveryCharge(20,3.2);
        obj.CalculateDeliveryCharge(35,2.5,"Yes");
    }
}