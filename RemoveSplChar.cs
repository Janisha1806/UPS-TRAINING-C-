public class RemoveSplChar
{
    public static void Main(string[] args)
    {
        string word = "Hello@123#World!";
        string new_word = "";
        for(int i=0;i<word.Length;i++){
            char c = word[i];
            if (char.IsLetterOrDigit(c))
            {
                new_word += c;
            }        
        }
        Console.WriteLine("After removing special characters of the word: "+ new_word);
    }
}