
using System;

class A
{
    public void Even()
    {
        Console.WriteLine("Enter the number:");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n % 2 == 0)
        {
            Console.WriteLine("It is Even Number");
        }
        else
        {
            Console.WriteLine("It is Odd Number");
        }
    }
}

class Method
{
    public static void Main(string[] args)
    {
        A obj = new A();
        obj.Even();
    }
}
