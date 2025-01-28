namespace MicrosoftLn.Intro.Part3{

public class Control{

    public void Ex01(){

        string name = "Steve";

        if (name == "bob") 
            Console.WriteLine ("Found Bob");
        else if (name == "Steve") 
            Console.WriteLine ("Found Steve");
        else 
            Console.WriteLine ("No name founded");

    }

    public void Exercise(){

        int [] numbers = {4,8,15,16,23,42};

        int total = 0;
        
        foreach (int number in numbers){
            total += number;

            if (number == 42){
                bool found = true;
            
                if (found){
                Console.WriteLine("Set contains 42");
                }
            }    
        }

        Console.WriteLine($"Total: {total}");
    }
}
}