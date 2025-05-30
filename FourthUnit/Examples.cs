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

    }
}
