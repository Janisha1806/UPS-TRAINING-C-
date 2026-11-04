using System;
using System.Threading;
class CalcThreadAdd2 {
  public static void Add(){
      
      Console.WriteLine("Add start");
      Thread.Sleep(3000);
      Console.WriteLine("Add end , CurrentThread: "+Thread.CurrentThread.Name);
  }
}
class CalcThreadSub2 {
   public void Sub(){
      
      Console.WriteLine("Sub start , CurrentThread: "+Thread.CurrentThread.Name);
      Thread.Sleep(3000);
      Console.WriteLine("Sub end ");
  }
}

class CalcThreadName{
    static void Main(){
        //Normal 
        CalcThreadSub2 c = new CalcThreadSub2();
        //static
        Thread t1 = new Thread(CalcThreadAdd2.Add);
        Thread t2 = new Thread(c.Sub);
        t1.Name = "Add";
        t2.Name = "Sub";
        t1.Start();
        t2.Start();
    } 
}