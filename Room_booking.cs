public class Room_booking
{
    public static void Main(String[] args)
    {
        Console.WriteLine("---WELCOME TO LIV HOTELS---");
        Console.WriteLine("Enter your room type: ");
        Console.WriteLine(" 1 for Standard Room(₹1500/night)\n 2 for Deluxe Room(₹2500/night) \n 3 for Suite Room(₹4000/night)");
        String room_type = Console.ReadLine();
        if (room_type == "1" || room_type == "2" || room_type == "3")
        {
            Console.WriteLine("Enter number of nights you want to stay: ");
            int nights = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you want food service? (yes/no)");
            String food_service = Console.ReadLine();
            Console.WriteLine("Do you have membership card? (yes/no)");
            String membership = Console.ReadLine();
            float roomcost = 0;
            switch (room_type)
            {
                case "1":
                    roomcost = 1500 * nights;
                    break;
                case "2":
                    roomcost = 2500 * nights;
                    break;
                case "3":
                    roomcost = 4000 * nights;
                    break;
                default:
                    Console.WriteLine("Invalid room type");
                    break;
        }
            if (food_service == "yes")
            {
                roomcost += 500 * nights;
            }
            if (membership == "yes")
            {
                roomcost -= 0.05f * roomcost;
            }
            float gst = 0.12f * roomcost;
            roomcost = roomcost + gst;
            Console.WriteLine("---YOUR BILL---");
            Console.WriteLine("Room Type: " + room_type + "\nRoom Cost: " + roomcost);
            Console.WriteLine("Number of nights: " + nights);
            if (food_service == "yes")
            {
                Console.WriteLine("Food Service: " +(500 * nights));
            }
            if (membership == "yes")
            {
                Console.WriteLine("Membership Discount: 5%");
            }
            Console.WriteLine("GST: 12%");
            Console.WriteLine("Total Cost: " + roomcost);
            }
            else
            {
                Console.WriteLine("Invalid room type. Please try again with correct room type.");
            }
            
    }
}