using System;

 namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp = "testando TESTANdO";

            //turn string to upper case
            Console.WriteLine(temp.ToUpper());

            //turn string to lower case
            Console.WriteLine(temp.ToLower());
            
            //remove blank space in begining and end of string
            Console.WriteLine(temp.Trim());

            //return index of search in string
            Console.WriteLine(temp.IndexOf("d"));

            //return last index of search in string
            Console.WriteLine(temp.LastIndexOf("d"));

            //return substring from certain index passed
            Console.WriteLine(temp.Substring(9));

            //return substring from certain index and x caracteres passed in second parameter
            Console.WriteLine(temp.Substring(3, 5));

            //replace old caracters for new ones
            Console.WriteLine(temp.Replace('t', 'X'));

            //replace old strings for new ones
            Console.WriteLine(temp.Replace("and", "WESLEY"));

            //return true if string is null or empty
            bool b1 = String.IsNullOrEmpty("");
            Console.WriteLine(b1);

            //return true if string is null or white space
            bool b2 = String.IsNullOrWhiteSpace("       ");
            Console.WriteLine(b2);
        }
    }
}
