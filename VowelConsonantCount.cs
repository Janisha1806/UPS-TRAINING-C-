public class VowelConsonantCount
{
    public static void Main(string[] args)
    {
        string word = "Education";
        int vcount = 0;
        int ccount = 0;
        for(int i=0;i<word.Length;i++){
            char c = word[i];
            
            if (c == 'A' || c== 'E'|| c=='I' || c=='O'||c=='U' || c=='a' || c=='e' || c=='i' || c=='o'|| c=='u'){
                vcount ++;
            }
            else{
                ccount++;
            }
                  
        }
        Console.WriteLine("Vowel count:  "+ vcount);
        Console.WriteLine("Consonant count:  "+ ccount);
    }
}