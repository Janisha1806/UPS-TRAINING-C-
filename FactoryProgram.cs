public interface IPayment { 
    void Pay();
}  
public class GPay : IPayment { 
    public void Pay() => Console.WriteLine("Payment through GPay"); 
} 
public class Cash : IPayment {    
    public void Pay() => Console.WriteLine("Payment through Cash");
}
public class CreditCard : IPayment {    
    public void Pay() => Console.WriteLine("Payment through CreditCard");
} 

public class ShapeFactory {   
    public static IPayment GetChoice(string choice){ 
        if (choice == "GPay")   
            return new GPay();   
        else if (choice == "Cash")   
            return new Cash();   
        else if (choice == "CreditCard")   
            return new CreditCard();  
        else        
            return null;   
    }
} 
class FactoryProgram {    
    static void Main(){       
        IPayment obj1 = ShapeFactory.GetChoice("GPay");
        obj1.Pay();       
        IPayment obj2 = ShapeFactory.GetChoice("Cash"); 
        obj2.Pay();       
        IPayment obj3 = ShapeFactory.GetChoice("CreditCard"); 
        obj3.Pay();       
    }
}