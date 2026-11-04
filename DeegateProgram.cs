using System;
using System.Collections.Generic;
class DelegateProgram
{
    // define a method that returns sum of two int numbers 
    static int Add(int x, int y)
    {
        return x + y;
    }
    static int Sub(int x, int y)
    {
        return x - y;
    }
    static int Mul(int x, int y)
    {
        return x * y;
    }
    static int Div(int x, int y)
    {
        return x / y;
    }
    // define a delegate
    public delegate int myDelegate(int num1, int num2);
    static void Main()
    {
        myDelegate d = new myDelegate(Add);
        Console.WriteLine("Addition: " + d(5, 6));
        d = Sub;
        Console.WriteLine("Subtraction: " + d(5, 6));
        d = Mul;
        Console.WriteLine("Multiplication: " + d(5, 6));
        d = Div;
        Console.WriteLine("Divition: " + d(10, 5));
    }
}