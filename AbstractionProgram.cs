abstract class Operation {       
    public abstract void Add(int a, int b);
    public abstract void Sub(int a, int b);
    public void Info(){  
        Console.WriteLine("We are performing math operations");  
    }
}  
class OperationClass : Operation
{ 
    public override void Add(int a,int b) 
    {       
        Console.WriteLine("Add: "+(a+b)); 
    }
    public override void Sub(int a,int b) 
    {       
        Console.WriteLine("Sub: "+(a-b)); 
    }
    public void Mul(int a, int b){
        Console.WriteLine("Mul: "+(a*b));
    }
    public void Div(int a, int b){
        Console.WriteLine("Div: "+(a/b));
    }
}  
class AbstractionProgram{     
    static void Main(){
        OperationClass obj = new OperationClass();  
        obj.Info();
        obj.Add(2,3);
        obj.Sub(10,3);
        obj.Mul(10,3);
        obj.Div(10,5);
    }
} 
