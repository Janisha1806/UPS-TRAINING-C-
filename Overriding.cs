class A
{
    public void Add(int a, int b)
    {
        Console.WriteLine("Parent Addition: " + (a + b));
    }
}
class B : A
{
    public void Add(int a, int b)
    {
        base.Add(a, b);
        Console.WriteLine("Child Addition: " + (a + b));
    }
    public void Sub(int a, int b)
    {
        Console.WriteLine("Subtraction: " + (a - b));
    }
}
class Overriding
{
    static void Main(string[] args)
    {
        B obj = new B();
        obj.Add(2, 3);
        obj.Sub(5, 2);
    }
}