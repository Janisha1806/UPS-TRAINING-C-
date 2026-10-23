public class SubstringCount
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string word = Console.ReadLine();
        Console.WriteLine("Enter substring:");
        string sub = Console.ReadLine();
        int count = 0;
        if (sub.Length > 0)
        {
            for (int i = 0; i <= word.Length - sub.Length; i++)
            {
                if (word.Substring(i, sub.Length) == sub)
                {
                    count++;
                    i += sub.Length - 1;
                }
            }
        }
        Console.WriteLine("Occurrences: " + count);
    }
}