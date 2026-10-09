public class Login
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter your username: ");
        String username = Console.ReadLine();
        Console.WriteLine("Enter your password: ");
        String password = Console.ReadLine();
        String correct_username = "Janisha";
        String correct_password = "1234";
        if(username == correct_username && password == correct_password)
        {
            Console.WriteLine("Login Successful");
        
        }
        else if(username != correct_username && password == correct_password)
        {
            Console.WriteLine("Incorrect Username");
        }
        else if(username == correct_username && password != correct_password)
        {
            Console.WriteLine("Incorrect Password");
        }
        else if(username != correct_username && password != correct_password)
        {
            Console.WriteLine("Both Username and Password are Incorrect");
        }
        
    }
}