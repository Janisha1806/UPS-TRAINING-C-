
using System;
using System.IO;

public class InvalidException : Exception
{
    public InvalidException(string message) : base(message)
    {
    }
}

public class InsufficientException : Exception
{
    public InsufficientException(string message) : base(message)
    {
    }
}

public class AtmFile
{
    private static double balance = 20000;

    public static void Main(string[] args)
    {
        Console.WriteLine("===== ATM BANKING SYSTEM =====");
        Console.WriteLine("Current Date: " + DateTime.Now.ToString("dd-MM-yyyy"));

        Console.WriteLine("\n1. Deposit");
        Console.WriteLine("2. Withdraw");
        Console.WriteLine("3. Balance Check");

        Console.Write("\nEnter your choice: ");
        string choice = Console.ReadLine() ?? "";

        string method = "";
        string status = "Failed";
        double amount = 0;

        try
        {
            switch (choice)
            {
                case "1":
                    method = "Deposit";
                    amount = Deposit();
                    status = "Success";
                    break;

                case "2":
                    method = "Withdraw";
                    amount = Withdraw();
                    status = "Success";
                    break;

                case "3":
                    method = "Balance Check";
                    amount = CheckBalance();
                    status = "Success";
                    break;

                default:
                    method = "Invalid Choice";
                    throw new InvalidException("Please select a valid option.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid number.");
        }
        catch (InvalidException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (InsufficientException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("\n===== TRANSACTION DETAILS =====");

            Console.WriteLine("Date and Time: " +
                DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));

            Console.WriteLine("Method: " + method);
            Console.WriteLine("Status: " + status);

            if (method == "Balance Check")
            {
                Console.WriteLine("Current Balance: " + balance);
            }

            string log = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") +
                         " | Method: " + method +
                         " | Status: " + status;

            if (method == "Balance Check")
            {
                log += " | Balance: " + balance;
            }

            log += Environment.NewLine;

            File.AppendAllText("TransactionLog.txt", log);

            Console.WriteLine("Transaction log saved.");
            Console.WriteLine("Transaction Completed.");
        }
    }

    private static double Deposit()
    {
        Console.Write("\nEnter amount to deposit: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        if (amount <= 0)
        {
            throw new InvalidException(
                "Deposit amount must be greater than zero.");
        }

        balance += amount;

        Console.WriteLine("Deposit Successful!");

        return amount;
    }

    private static double Withdraw()
    {
        Console.Write("\nEnter amount to withdraw: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        if (amount <= 0)
        {
            throw new InvalidException(
                "Withdrawal amount must be greater than zero.");
        }

        if (amount > balance)
        {
            throw new InsufficientException("Insufficient balance.");
        }

        balance -= amount;

        Console.WriteLine("Withdrawal Successful!");

        return amount;
    }

    private static double CheckBalance()
    {
        Console.WriteLine("\nAvailable Balance: " + balance);
        Console.WriteLine("Balance checked successfully!");

        return balance;
    }
}


