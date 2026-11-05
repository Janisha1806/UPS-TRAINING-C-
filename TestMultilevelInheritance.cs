using System;

class Company
{
    string cname = "Scopetech Software Solution";
    string location = "Madurai";
    public void DisplayCompanyDetails()
    {
        Console.WriteLine("Company: " + cname);
        Console.WriteLine("Location: " + location);
    }
}
class Department : Company
{
    string departname = "Development";
    int departid = 101;
    public void DisplayDepartmentDetails()
    {
        Console.WriteLine("Department: " + departname);
        Console.WriteLine("Department ID: " + departid);
    }
}
class Employee : Department
{
    int employeeId = 1145;
    string employeeName = "Arun";
    int workingDays = 26;
    double monthlySalary = 25000;
    double dailysal;
    double annualsalary;
    public double CalculateAnnualSalary()
    {
        return annualsalary = monthlySalary * 12;
    }
    public double CalculateDailySalary()
    {
        return dailysal = monthlySalary / workingDays;
    }
    public void DisplayEmployeeDetails()
    {
        Console.WriteLine("Employee ID: " + employeeId);
        Console.WriteLine("Employee: " + employeeName);
        Console.WriteLine("Monthly Salary: " + monthlySalary);
        Console.WriteLine("Annual Salary: " + annualsalary);
        Console.WriteLine("Daily Salary: " + dailysal);
    }
}
class TestMultilevelInheritance
{
    static void Main()
    {
        Employee e = new Employee();
        e.DisplayCompanyDetails();
        e.DisplayDepartmentDetails();
        e.CalculateAnnualSalary();
        e.CalculateDailySalary();
        e.DisplayEmployeeDetails();
    }
}