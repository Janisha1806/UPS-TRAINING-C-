using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
class DictProgram {
  static void Main() {
    Console.WriteLine("Enter the dictionary size: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the dictionary elements: ");
    Dictionary<int,int> obj = new Dictionary<int,int>();
    for(int i =1;i<=n;i++){
        Console.WriteLine("Enter the key "+i+": ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value "+i+": ");
        int y = Convert.ToInt32(Console.ReadLine());
        obj.Add(x,y);
    }
    Console.WriteLine("Dictionary elements: ");
    foreach(KeyValuePair<int,int> j in obj){
        Console.WriteLine(j); 
    } 
  }
}
