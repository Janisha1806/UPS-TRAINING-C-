public class Vehicle_rent
{
    public static void Main(String[] args)
    {
        Console.WriteLine("---WELCOME TO LIV VEHICLE RENTAL---");
        Console.WriteLine("Do you have a driving license? (yes/no)");
        String driving_license = Console.ReadLine();
        if (driving_license == "yes")
        {
            Console.WriteLine("Enter your vehicle type: ");
            Console.WriteLine(" 1 for Bike(Rs.1000/day)\n 2 for Car(Rs.3000/day): ");   
            int vehicle = Convert.ToInt32(Console.ReadLine());
            if (vehicle == 1 || vehicle == 2)
            {
                Console.WriteLine("Enter number of days you want to rent the vehicle: ");
                int days = Convert.ToInt32(Console.ReadLine());
                float bill = 0;
                if (vehicle == 1)
                {
                    bill = 1000 * days;
                }
                else if (vehicle == 2)
                {
                    bill = 3000 * days;
                }
                Console.WriteLine("Your total bill is: Rs." + bill);
            }
            else
            {
                Console.WriteLine("Invalid vehicle type. Please try again with correct vehicle type.");
            }
        }
        else
        {
            Console.WriteLine("You are not eligible for vehicle rental without a driving license.");
        }
    }
}
