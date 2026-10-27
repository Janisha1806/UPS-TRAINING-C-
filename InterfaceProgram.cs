interface I1 {
    void Add(int a, int b);  
    void Sub(int a, int b);
}
interface I2 {
    void Mul(int a, int b);
    void Div(int a, int b);
}
class MathFunc: I1,I2 {
    public void Add(int a, int b){         
        Console.WriteLine("Add: "+(a+b));    
    }
    public void Sub(int a, int b){         
        Console.WriteLine("Sub: "+(a-b));    
    }
    public void Mul(int a, int b){         
        Console.WriteLine("Mul: "+(a*b));    
    }
    public void Div(int a, int b){         
        Console.WriteLine("Div: "+(a/b));    
    }
} 

class InterfaceProgram{ 
    static void Main(){
        MathFunc obj = new MathFunc();
        obj.Add(5,6);
        obj.Sub(10,5);
        obj.Mul(10,3);
        obj.Div(10,5);
    }
}