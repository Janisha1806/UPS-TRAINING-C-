public class Atm
{
    public static void Main(String[] args)
    {
        Console.WriteLine("---WELCOME---");
        Console.WriteLine("---INSERT YOUR CARD---");
        Console.WriteLine("ENTER YOUR PIN: ");  
        int pin = Convert.ToInt32(Console.ReadLine());
        int actual_pin = 123456;
        if (pin == actual_pin)
        {
            Console.WriteLine("---ENTER YOUR CHOICE---");
            Console.WriteLine(" 1 for check balance\n 2 for withdraw \n 3 for deposit");
            int choice = Convert.ToInt32(Console.ReadLine());
            int amnt_in_acc = 10000;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Your current balance: "+ amnt_in_acc);
                    break;
                case 2:
                    Console.WriteLine("Enter your amount to be withdrawn: ");
                    int withdraw = Convert.ToInt32(Console.ReadLine());
                    if (amnt_in_acc >= withdraw)
                    {
                        amnt_in_acc = amnt_in_acc - withdraw;
                        Console.WriteLine("Your current balance: "+ amnt_in_acc); 
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Balance");
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter your amount to be deposited: ");
                    int deposit = Convert.ToInt32(Console.ReadLine());
                    amnt_in_acc = amnt_in_acc + deposit;
                    Console.WriteLine("Your current balance: "+ amnt_in_acc);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;

            }
        }
        else
        {
            Console.WriteLine("Invalid pin. Please try again with correct pin.");
        }
        
    }
}