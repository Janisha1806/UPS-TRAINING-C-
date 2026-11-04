using System;
using System.Threading;
class CalcThreadAdd {
  public static void Add(){
      
      Console.WriteLine("Add start");
      Thread.Sleep(3000);
      Console.WriteLine("Add end");
  }
  
}
class CalcThreadSub {
   public void Sub(){
      
      Console.WriteLine("Sub start ");
      Thread.Sleep(3000);
      Console.WriteLine("Sub end ");
  }
  
}

class CalcThread{
    static void Main(){
        //Normal 
        CalcThreadSub c = new CalcThreadSub();
        //static
        Thread t1 = new Thread(CalcThreadAdd.Add);
        Thread t2 = new Thread(c.Sub);
        t1.Start();
        t2.Start();
        
    } 
}