
public class CopyArr
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

        Console.WriteLine("Original array:");

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }

        int[] copy = new int[arr.Length];

        Array.Copy(arr, copy, arr.Length);

        Console.WriteLine("Copied array:");

        for (int i = 0; i < copy.Length; i++)
        {
            Console.WriteLine(copy[i]);
        }
    }
}
