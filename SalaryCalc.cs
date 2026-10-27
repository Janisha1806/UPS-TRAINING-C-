using System.Runtime.CompilerServices;

public class CalcSal
{
    public void CalculateSalary(double sal1)
    {
        Console.WriteLine("Salary: "+sal1+" Total: "+sal1);
    }
    public void CalculateSalary(double sal2,double allowance)
    {
        Console.WriteLine("Salary: "+sal2+" Allowance: "+allowance+" Total: "+(sal2+allowance));
    }
    public void CalculateSalary(double sal3, double allowance2, double bonus)
    {
        Console.WriteLine("Salary: "+sal3+" Allowance: "+allowance2+" Bonus: "+bonus+" Total: "+(sal3+allowance2+bonus));
    }
}
public class SalaryCalc
{
    public static void Main(string[] args)
    {
        CalcSal obj = new CalcSal();
        obj.CalculateSalary(50000);
        obj.CalculateSalary(50000,1000);
        obj.CalculateSalary(50000,2000,500);
    }
}