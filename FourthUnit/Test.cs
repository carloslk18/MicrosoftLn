using System.Security.Cryptography.X509Certificates;

namespace MicrosoftLn.FourthUnit{
public class Test{

    public void FinalTest(){

        string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

        string [] order = orderStream.Split(',');
        Array.Sort(order);
        
        for (int x = 0; x < order.Length; x++){
            if (order[x].Length != 4){
                Console.WriteLine($"{order[x]} - Error");
            }
            else {
                Console.WriteLine(order[x]);
            }
        }
    }
}
}
