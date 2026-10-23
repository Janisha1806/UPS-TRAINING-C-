public class LongestWord
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();
        string[] words = sentence.Split(' ');
        string longest = "";
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > longest.Length)
            {
                longest = words[i];
            }
        }
        Console.WriteLine("Longest word: " + longest);
    }
}