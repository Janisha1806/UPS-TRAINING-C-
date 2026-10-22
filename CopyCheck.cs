public class CopyCheck
{
    public static void Main(string[] args)
    { 
        Console.WriteLine("Enter the array size:");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];

        Console.WriteLine("Enter the array elements:");

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int[] copy = new int[arr.Length];
        Array.Copy(arr,copy,arr.Length);
        Console.WriteLine("Copied elements :");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(copy[i]);
        }
        string arr1 = string.Join(",",arr);
        string copy1 = string.Join(",",copy);
        if(arr1 == copy1){
            Console.WriteLine("Same elements");
        }
    }
}