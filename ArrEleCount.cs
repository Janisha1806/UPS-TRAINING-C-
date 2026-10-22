public class ArrEleCount
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
        bool[] visited = new bool[size];
        for(int i=0; i<arr.Length;i++){
            if (visited[i])
                continue;
            int count =0;
            int key = arr[i];
            for(int j=0;j<arr.Length;j++){
                if(arr[j]==key){
                   count++; 
                   visited[j] = true;
                }
            }
            Console.WriteLine(arr[i]+"is in the array "+count+" times");
        }
    }
}
