using System;
using System.Collections.Generic;
class ListProgram {
  static void Main() {
    Console.WriteLine("Enter the list size: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the list elements: ");
    List<int> obj = new List<int>();
    for(int i =0;i<n;i++){
        int x = Convert.ToInt32(Console.ReadLine());
        obj.Add(x);
    }
    Console.WriteLine("List elements: ");
    foreach(var j in obj){
        Console.WriteLine(j);          
    } 
  }
}