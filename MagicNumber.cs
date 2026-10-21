
public class MagicNumber
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

            while (n > 9)
            {
                int sum = 0;

                while (n > 0)
                {
                    sum = sum + n % 10;
                    n = n / 10;
                }

                n = sum;
            }

            if (n == 1)
            {
                count++;
                Console.WriteLine(arr[i] + " is a magic number");
            }
        }

        Console.WriteLine("Magic number count: " + count);
    }
}
