public class Armstrong_3
{
    public static void Main(String[] args)
    {
        Console.WriteLineLine("Enter the size of array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        for(int z = 0; z < arr.Length; z++)
        {
            arr[z] = Convert.ToInt32(Console.ReadLine());
        }
        for(int z = 0; z < arr.Length; z++)
        {
            int cube = 1;
            int sum = 0;
            
            
            int n = arr[z];
            int num = n;
            while(n>0){
                int r = n %10;
                cube = r*r*r;
                sum+=cube;
                //count++;
                n = n/10;
            }
            if(sum==num){
                Console.WriteLine("Armstrong number");
            }
            else{
                Console.WriteLine("Not an Armstrong number");

            }
        }
    }
}
