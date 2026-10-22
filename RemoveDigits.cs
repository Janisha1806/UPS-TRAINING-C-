public class RemoveDigits
{
    public static void Main(string[] args)
    {
        string word = "Madurai123City45";
        string new_word = "";
        for(int i=0;i<word.Length;i++){
            char c = word[i];
            if (!char.IsDigit(c))
            {
                new_word += c;
            }        
        }
        Console.WriteLine("After removing digits of the word: "+ new_word);
    }
}