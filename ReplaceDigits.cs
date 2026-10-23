public class ReplaceDigits
{
    public static void Main(string[] args)
    {
        string word = "abc123xyz45";
        string new_word = "";
        for(int i=0;i<word.Length;i++){
            char c = word[i];
            if (!char.IsDigit(c))
            {
                new_word += c;
            }
            else{
                new_word += '*';
            }
        }
        Console.WriteLine("After replacing digits: "+ new_word);
    }
}