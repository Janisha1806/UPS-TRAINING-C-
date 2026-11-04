using System;

static class ClassName
{
    public static void FullName(this string firstname, string lastname)
    {
        if (string.IsNullOrWhiteSpace(firstname))
        {
            Console.WriteLine("Full Name: " + lastname);
        }

        if (string.IsNullOrWhiteSpace(lastname))
        {
            Console.WriteLine("Full Name: " + firstname);
        }

        Console.WriteLine("Full Name: " + firstname + " " + lastname);
    }
}

class Nameprogram
{
    static void Main()
    {
        string firstname = "Janisha";
        string lastname = "Mathialagan";
        Console.WriteLine("First Name: " + firstname);
        Console.WriteLine("Last Name: " + lastname);
        firstname.FullName(lastname);
    }
}