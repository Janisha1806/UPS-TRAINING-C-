public class Login_nested_if
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter your username: ");
        String username = Console.ReadLine();
        Console.WriteLine("Enter your password: ");
        String password = Console.ReadLine();
        String correct_username = "Janisha";
        String correct_password = "1234";
        if(username == correct_username)
        {
            if(password == correct_password)
            {
                Console.WriteLine("Login Successful");
            }
            else
            {
                Console.WriteLine("Incorrect Password");
            }
        }
        else
        {
            Console.WriteLine("Incorrect Username");
        }
    }
}