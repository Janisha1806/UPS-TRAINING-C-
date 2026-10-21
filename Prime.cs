
using System;

public class Prime
{
    public static void Main(String[] args)
    {
        int size = 5;
        int[] arr = new int[size];

        for (int z = 0; z < arr.Length; z++)
        {
            arr[z] = Convert.ToInt32(Console.ReadLine());
        }

        for (int z = 0; z < arr.Length; z++)
        {
            int count = 0;
            int n = arr[z];

            if (n < 2)
            {
                Console.WriteLine(n + " is neither prime nor composite");
                continue;
            }

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                    break;
                }
            }

            if (count > 0)
            {
                Console.WriteLine(n + " is not a prime number");
            }
            else
            {
                Console.WriteLine(n + " is a prime number");
            }
        }
    }
}
