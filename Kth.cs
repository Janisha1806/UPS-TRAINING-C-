public class Kth
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
        Console.WriteLine("Enter the Kth element for which you have to find the smallest: ");
        int small = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Kth element for which you have to find the largest: ");
        int large = Convert.ToInt32(Console.ReadLine());
        Array.Sort(arr);
        Console.WriteLine( small+" smallest element is: "+arr[small-1]);
        Console.WriteLine( small+" largest element is: "+arr[arr.Length - large]);
 
    }
}