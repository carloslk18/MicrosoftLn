namespace MicrosoftLn.Intro.Part3{

public class Comparison{

    public void Ex01(){

        // string value = " a";
        // string value2 = "A ";

        // Console.WriteLine(value.Trim().ToLower() == value2.Trim().ToLower());

        // string pangram = "The quick brown fox jumps over the lazy dog.";
        // Console.WriteLine(pangram.Contains("fox"));
        // Console.WriteLine(pangram.Contains("cow"));

        string pangram = "The quick brown fox jumps over the lazy dog.";
        Console.WriteLine(pangram.Contains("fox"));
        Console.WriteLine(!pangram.Contains("cow"));     

    }
}
}