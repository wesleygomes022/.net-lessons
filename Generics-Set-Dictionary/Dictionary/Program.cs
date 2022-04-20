using System;
using System.Collections.Generic;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cook = new Dictionary<string, string>();
            cook.Add("fname", "Wesley");
            cook.Add("lname", "Gomes");
            cook.Add("email", "wesleygomespaiva43@gmail.com");
            cook.Add("phone", "11941579136");
            cook["age"] = "22";

            Console.WriteLine(cook["lname"]);
            //cook.Clear();
            Console.WriteLine(cook.Count);
            /*Console.WriteLine(cook.ContainsKey("fname"));
            Console.WriteLine(cook.ContainsKey("banana"));
            Console.WriteLine(cook.ContainsValue("banana"));
            Console.WriteLine(cook.ContainsValue("Wesley"));*/

            /*string temp;
            cook.Remove("fname", out temp);
            Console.WriteLine(temp);*/

            Console.WriteLine("\n");

            foreach(KeyValuePair<string, string> value in cook)
            {
                //Console.WriteLine(value.Key);
                //Console.WriteLine(value.Value);
                Console.WriteLine(value);
            }
        }        
    }
}
