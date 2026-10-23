public class Automorphic
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());
        double sq = Math.Pow(num,2);
        string c = sq.ToString();
        string n = num.ToString();
        if(c.EndsWith(n)){
            Console.WriteLine("Automorphic");
        }
        else{
            Console.WriteLine("Not Automorphic");
        }
    }
}