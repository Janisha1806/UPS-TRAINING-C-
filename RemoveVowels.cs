public class RemoveVowels
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string word = Console.ReadLine();
        string result = "";
        for (int i = 0; i < word.Length; i++)
        {
            char c = char.ToLower(word[i]);
            if (c != 'a' && c != 'e' && c != 'i' &&
                c != 'o' && c != 'u')
            {
                result += word[i];
            }
        }
        Console.WriteLine("After removing vowels: " + result);
    }
}