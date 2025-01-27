namespace MicrosoftLn.Intro.Part3{

public class ConditionOp{

    public void Ex01(){
        int saleAmount = 1001;
        int discount = saleAmount > 1000 ? 100 : 50;
        Console.WriteLine($"Discount: {discount}");

    }
}
}