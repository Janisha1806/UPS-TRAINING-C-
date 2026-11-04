using System;

static class StringExtensions1
{
    public static int CountVowels(this string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return 0;
        }
        int count = 0;
        foreach (char ch in text.ToLower())
        {
            if (ch == 'a' || ch == 'e' || ch == 'i' ||
                ch == 'o' || ch == 'u')
            {
                count++;
            }
        }
        return count;
    }
}

class CountVowels
{
    static void Main()
    {
        string name = "Hello Students";
        int count = name.CountVowels();
        Console.WriteLine("Text: " + name);
        Console.WriteLine("Vowels Count: " + count);
    }
}