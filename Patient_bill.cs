public class Patient_bill
{
    public static void Main(String[] args)
    {
        Console.WriteLine("---WELCOME TO LIV HOSPITAL---");
        Console.WriteLine("Select your ward type 1 for General Ward(Rs.500/day), 2 for private Ward(Rs.2000/day), 3 for ICU(Rs.5000/day): " );
        int ward_type = Convert.ToInt32(Console.ReadLine());
        if (ward_type == 1 || ward_type == 2 || ward_type == 3)
        {
            int consultation = 800;
            Console.WriteLine("Enter number of days you stayed in hospital: ");
            int days = Convert.ToInt32(Console.ReadLine());
            float bill = 0;
            if(ward_type == 1)
            {
                bill = 500 * days; 
            }
            else if(ward_type == 2)
            {
                bill = 2000 * days; 
            }
            else if(ward_type == 3)
            {
                bill = 5000 * days; 
            }
            bill += consultation;
            float senior_citizen_discount = 0.05f * bill;
            bill -= senior_citizen_discount;
            Console.WriteLine("Your total bill is: Rs." + bill);
        }
        else
        {
            Console.WriteLine("Invalid ward type. Please try again with correct ward type.");
        }
    }
}