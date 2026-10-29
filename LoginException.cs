public class InvalidLoginException : Exception
{
    public InvalidLoginException(string message) : base(message)
    {
    }
}
public class LoginException
{
    public static void Main(string[] args)
    {
        try
        {
           int pin = 1234;
           int psw = 0;
           int count = 0;
           while(pin!=psw){
               if(count==3){
                   throw new InvalidLoginException("Login failed. Too many attempts");
                   break;
               }
                 if(count==0){
                    Console.WriteLine("Enter the password: ");
                 }
                 if(count!=0){
                    Console.WriteLine("Re-enter the password correctly: ");
                 }
                 
                 psw = Convert.ToInt32(Console.ReadLine());
                 count++;
                 if(pin==psw){
                     Console.WriteLine("Login Successful");
                 }
           }
           
        }
        catch (InvalidLoginException e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("No More attempts.Sorry.");
        }
        finally
        {
            Console.WriteLine("Login process ended.");
        }
    }
}