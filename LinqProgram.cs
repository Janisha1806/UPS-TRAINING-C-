using System;
using System.Collections.Generic;
using System.Linq;

// Student Class
class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Department { get; set; } = "";
    public int Marks { get; set; }
}

class LinqProgram
{
    static void Main()
    {
        // Student Collection
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Arun", Department = "CSE", Marks = 85 },
            new Student { Id = 2, Name = "Priya", Department = "IT", Marks = 90 },
            new Student { Id = 3, Name = "Kumar", Department = "CSE", Marks = 45 },
            new Student { Id = 4, Name = "Divya", Department = "ECE", Marks = 75 },
            new Student { Id = 5, Name = "Ravi", Department = "IT", Marks = 25 }
        };

// WHERE - Marks below 30
        Console.WriteLine("\n1. WHERE - Marks below 30");
        var resultb30 = students.Where(s => s.Marks < 30);
        foreach (var s in resultb30)
        {
            Console.WriteLine(s.Name + " - " + s.Marks);
        }

        // WHERE - Marks above 80
        Console.WriteLine("\n2. WHERE - Marks above 80");
        var resulta80 = students.Where(s => s.Marks > 80);
        foreach (var s in resulta80)
        {
            Console.WriteLine(s.Name + " - " + s.Marks);
        }

        // GROUPBY - Group students by department
        Console.WriteLine("\n3. GROUPBY - Department");
        var result15 = students.GroupBy(s => s.Department);
        foreach (var group in result15)
        {
            Console.WriteLine("\nDepartment: " + group.Key);

            foreach (var s in group)
            {
                Console.WriteLine(s.Name + " - " + s.Marks);
            }
        }

        // GROUPBY - Department with marks above 80
        Console.WriteLine("\n4. GROUPBY - Department with marks above 80");

        var resultd = students
            .Where(s => s.Marks > 80)
            .GroupBy(s => s.Department);
        foreach (var group in resultd)
        {
            Console.WriteLine("\nDepartment: " + group.Key);
            foreach (var s in group)
            {
                Console.WriteLine(s.Name + " - " + s.Marks);
            }
        }

        // MAX - Highest marks
        Console.WriteLine("\n5. MAX - Highest Marks");
        int result12 = students.Max(s => s.Marks);
        Console.WriteLine("Highest Marks: " + result12);

        // MAX - Department wise
        Console.WriteLine("\n6. MAX - Department Wise");
        var result = students.GroupBy(s => s.Department);
        foreach (var group in result)
        {
            Console.WriteLine("Department: " + group.Key);
            Console.WriteLine("Maximum Mark: " + group.Max(s => s.Marks));
        }

        // MIN - Department wise
        Console.WriteLine("\n7. MIN - Department Wise");
        foreach (var group in result)
        {
            Console.WriteLine("Department: " + group.Key);
            Console.WriteLine("Minimum Mark: " + group.Min(s => s.Marks));
        }

        // MIN - Lowest marks
        Console.WriteLine("\n8. MIN - Lowest Marks");
        int result13 = students.Min(s => s.Marks);
        Console.WriteLine("Lowest Marks: " + result13);
    }
}