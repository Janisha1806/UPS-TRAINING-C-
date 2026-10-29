class BankAccount
{
    int amnt_in_acc = 10000;

    public void CheckBalance()
    {
        Console.WriteLine("Your current balance: " + amnt_in_acc);
    }

    public void Withdraw(int withdraw)
    {
        if (withdraw <= 0)
        {
            throw new ArgumentException("Enter a valid withdrawal amount.");
        }

        if (withdraw > amnt_in_acc)
        {
            throw new Exception("Insufficient Balance.");
        }

        amnt_in_acc = amnt_in_acc - withdraw;
        Console.WriteLine("Withdrawal successful.");
        CheckBalance();
    }

    public void Deposit(int deposit)
    {
        if (deposit <= 0)
        {
            throw new ArgumentException("Enter a valid deposit amount.");
        }

        amnt_in_acc = amnt_in_acc + deposit;
        Console.WriteLine("Deposit successful.");
        CheckBalance();
    }
}

public class AtmException
{
    public static void Main(string[] args)
    {
        BankAccount obj = new BankAccount();

        try
        {
            Console.WriteLine("---WELCOME---");
            Console.WriteLine("---INSERT YOUR CARD---");
            Console.WriteLine("ENTER YOUR PIN:");

            int pin = Convert.ToInt32(Console.ReadLine());
            int actual_pin = 123456;

            if (pin == actual_pin)
            {
                Console.WriteLine("---ENTER YOUR CHOICE---");
                Console.WriteLine("1 for Check Balance");
                Console.WriteLine("2 for Withdraw");
                Console.WriteLine("3 for Deposit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        obj.CheckBalance();
                        break;

                    case 2:
                        Console.WriteLine("Enter amount to withdraw:");
                        int withdraw = Convert.ToInt32(Console.ReadLine());
                        obj.Withdraw(withdraw);
                        break;

                    case 3:
                        Console.WriteLine("Enter amount to deposit:");
                        int deposit = Convert.ToInt32(Console.ReadLine());
                        obj.Deposit(deposit);
                        break;

                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid PIN. Please try again.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter integer values only.");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("ATM transaction ended.");
        }
    }
}