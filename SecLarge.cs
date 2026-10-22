public class SecLarge
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
        Console.WriteLine("The second largest element is: "+arr[arr.Length - 2]);
 
    }
}