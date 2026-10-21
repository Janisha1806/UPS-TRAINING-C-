public class Oddsum
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter array size:");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];
        Console.WriteLine("Enter the elements: ");

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 != 0)
            {
                sum = sum + arr[i];
            }
        }

        Console.WriteLine("Odd sum: " + sum);
    }
}
