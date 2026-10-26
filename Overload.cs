class A{
    public void Add(int a1, int b1){
        int ans1 = a1+b1;
        Console.WriteLine(ans1);
    }
    public void Add(string a2, string b2){
        string ans2 = a2+b2;
        Console.WriteLine(ans2);
    }
    public void Add(double a3, double b3){
        double ans3 = a3+b3;
        Console.WriteLine(ans3);
    }
}
class Overload{
    public static void Main(string[] args){
        A obj = new A();
        obj.Add(4,5);
        obj.Add(2.3,3.2);
        obj.Add("wel","come");
    }
}