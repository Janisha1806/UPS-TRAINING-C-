
public class CountPrime
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

        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            int n = arr[i];
            int flag = 0;

            if (n < 2)
                continue;

            for (int j = 2; j < n; j++)
            {
                if (n % j == 0)
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
            {
                count++;
            }
        }

        Console.WriteLine("Prime count: " + count);
    }
}
