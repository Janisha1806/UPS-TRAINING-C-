using System;
using System.Threading;
class CalcThreadAdd1 {
  public static void Add(int a,int b){
      
      Console.WriteLine("Add start "+(a+b));
      Thread.Sleep(3000);
      Console.WriteLine("Add end");
  }
}
class CalcThreadSub1 {
   public void Sub(int a, int b){
      
      Console.WriteLine("Sub start "+(a-b));
      Thread.Sleep(3000);
      Console.WriteLine("Sub end ");
  }
}
class CalcThreadArg{
    static void Main(){
        //Normal 
        CalcThreadSub1 c = new CalcThreadSub1();
        //static
        Thread t1 = new Thread(()=>CalcThreadAdd1.Add(12,56));
        Thread t2 = new Thread(()=>c.Sub(23,7));
        t1.Start();
        t2.Start();
    } 
}