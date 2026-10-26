class Methodsystem
{
    int students;
    string[] name;
    int[] eng, mat, phy, chem, bio, total, roll;
    double[] avg;
    char[] grade;
    public void GetDetails()
    {
        Console.WriteLine("Enter the number of students:");
        students = Convert.ToInt32(Console.ReadLine());
        name = new string[students];
        roll = new int[students];
        eng = new int[students];
        mat = new int[students];
        phy = new int[students];
        chem = new int[students];
        bio = new int[students];
        total = new int[students];
        avg = new double[students];
        grade = new char[students];
        for (int i = 0; i < students; i++)
        {   Console.WriteLine("Enter student"+(i+1)+"'s name: ");
            name[i]= Console.ReadLine();
            Console.WriteLine("Enter student"+(i+1)+"'s reg number: ");
            roll[i]= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student " + name[i] + "'s English marks:");
            eng[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Mathematics marks:");
            mat[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Physics marks:");
            phy[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Chemistry marks:");
            chem[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Biology marks:");
            bio[i] = Convert.ToInt32(Console.ReadLine());
            total[i] = CalculateTotal(
                eng[i], mat[i], phy[i], chem[i], bio[i]);
            avg[i] = CalculateAverage(total[i]);
            grade[i] = DisplayGrade(avg[i]);
        }
    }
    public void ShowStudentDetails()
    {
        for (int i = 0; i < students; i++)
        {
            Console.WriteLine("\nStudent " + (i + 1));
            Console.WriteLine("\nStudent Name: " + name[i]);
            Console.WriteLine("\nStudent Roll Number: " + roll[i]);
            Console.WriteLine("English: " + eng[i]);
            Console.WriteLine("Mathematics: " + mat[i]);
            Console.WriteLine("Physics: " + phy[i]);
            Console.WriteLine("Chemistry: " + chem[i]);
            Console.WriteLine("Biology: " + bio[i]);
            Console.WriteLine("Total: " + total[i]);
            Console.WriteLine("Average: " + avg[i]);
            Console.WriteLine("Grade: " + grade[i]);
            Console.WriteLine("--------------------------------");
        }
    }
    public int CalculateTotal(int e, int m, int p, int c, int b)
    {
        return e + m + p + c + b;
    }
    public double CalculateAverage(int totalMarks)
    {
        return totalMarks / 5.0;
    }
    public char DisplayGrade(double average)
    {
        if (average >= 90)
            return 'S';
        else if (average >= 80)
            return 'A';
        else if (average >= 70)
            return 'B';
        else if (average >= 60)
            return 'C';
        else if (average >= 60)
            return 'D';   
        else
            return 'U';
    }
}

class StudentSystem
{
    static void Main()
    {
        Methodsystem obj = new Methodsystem();
        obj.GetDetails();
        obj.ShowStudentDetails();
    }
}
