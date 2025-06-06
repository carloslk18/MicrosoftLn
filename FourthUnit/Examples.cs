namespace MicrosoftLn.FourthUnit{
    public class Examples
    {

        public void Ex01()
        {
            string value = "abc123";
            char[] valueArray = value.ToCharArray();
            Array.Reverse(valueArray);

            string result = String.Join(",", valueArray);
            Console.WriteLine(result);

            string[] items = result.Split(',');

            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
        }

        public void Ex02()
        {
            string message = "Find what is <span>between the tags</span>?";

            int openingPosition = message.IndexOf("<span>");
            int closingPosition = message.IndexOf("</span>");

            //Console.WriteLine(openingPosition);
            //Console.WriteLine(closingPosition);
            openingPosition += 6;

            int lenght = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, lenght));
        }

        public void Ex03()
        {
            int a = 3;
            int b = 4;
            int c = 0;

            Multiply(a, b, c);
            Console.WriteLine($"global statement: {a} x {b} = {c}");
        }

        void Multiply(int a, int b, int c)
        {
            c = a * b;
            Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
        }

        public void Ex04()
        {
            int[] array = { 1, 2, 3, 4, 5 };

            PrintArray(array);
            Clear(array);
            PrintArray(array);
        }

        public void PrintArray(int[] array)
        {
            foreach (int a in array)
            {
                Console.Write($"{a} ");
            }
            Console.WriteLine();
        }

        public void Clear(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 0;
            }
        }

        public void Ex05()
        {
            string status = "Healthy";

            Console.WriteLine($"Start: {status}");
            SetHealth(status, false);
            Console.WriteLine($"End: {status}");
        }
        
        void SetHealth(string status, bool isHealthy) 
        {
            status = (isHealthy ? "Healthy" : "Unhealthy");
            Console.WriteLine($"Middle: {status}");
        }
        
    }
}
