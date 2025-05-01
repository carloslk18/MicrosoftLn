namespace MicrosoftLn.FourthUnit{
public class Examples{

    public void Ex01(){
        string value = "abc123";
        char[] valueArray = value.ToCharArray();
        Array.Reverse(valueArray);

        string result = String.Join(",",valueArray);
        Console.WriteLine(result);

        string[] items = result.Split(',');
        foreach (string item in items){
            Console.WriteLine(item);

             string value = "abc123";
        char[] valueArray = value.ToCharArray();
        Array.Reverse(valueArray);

        string result = String.Join(",",valueArray);
        Console.WriteLine(result);

        string[] items = result.Split(',');
        foreach (string item in items){
            Console.WriteLine(item);
        }
    }
}
}
