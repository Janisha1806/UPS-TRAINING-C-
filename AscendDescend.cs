public class AscendDescend
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
        Array.Sort(arr);
        Console.WriteLine("Ascending order of the array: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
        Array.Reverse(arr);
        Console.WriteLine("Descending order of the array: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
 
    }
}
