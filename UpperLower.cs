public class UpperLower
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your word: ");
        string word = Console.ReadLine();
        string new_word = "";
        for(int i=0;i<word.Length;i++){
            char c = word[i];
            if(char.IsUpper(c))
                new_word +=char.ToLower(c);
            if(char.IsLower(c))
                new_word +=char.ToUpper(c);
        }
            Console.WriteLine("Viceversa case of entered word: "+ new_word);
            Console.WriteLine("Upper case of entered word: "+ new_word.ToUpper());
            Console.WriteLine("Upper case of entered word: "+ new_word.ToLower());
    }
}