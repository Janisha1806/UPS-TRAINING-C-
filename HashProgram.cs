using System;
using System.Collections.Generic;
class HashProgram {
  static void Main() {
    Console.WriteLine("Enter the hash size: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the hash elements: ");
    HashSet<int> obj = new HashSet<int>();
    for(int i =0;i<n;i++){
        int x = Convert.ToInt32(Console.ReadLine());
        obj.Add(x);
    }
    Console.WriteLine("Hash elements: ");
    foreach(var j in obj){
        Console.WriteLine(j);         
    } 
  }
}