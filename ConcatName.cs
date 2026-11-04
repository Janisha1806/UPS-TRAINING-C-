using System;

static class StringExtensions3
{
    public static string ConcatNamefull(this string text1, string text2, string text3)
    {
        if (string.IsNullOrWhiteSpace(text1) || string.IsNullOrWhiteSpace(text2) || string.IsNullOrWhiteSpace(text2))
        {
            return "";
        }
        else
        {
            string fullname = text1 + " " + text2+" "+text3;
            return fullname;
        }
    }
}

class ConcatName
{
    static void Main()
    {
        string fname = "Janisha";
        string mname = "Anbu";
        string lname = "Mathialagan";
        string fullname = fname.ConcatNamefull(mname,lname);
        Console.WriteLine("First Name: " + fname);
        Console.WriteLine("Middle Name: " + mname);
        Console.WriteLine("Last Name: " + lname);
        Console.WriteLine("Full Name: " + fullname);
    }
}