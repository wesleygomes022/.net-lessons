using System;
using System.IO;
using System.Collections.Generic;

namespace Studies
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"C:\temp\logs.txt";
            Dictionary<string, int> dic = new Dictionary<string, int>();
            using(StreamReader sr = File.OpenText(file))
            {
                while(!(sr.EndOfStream))
                {
                    string[] temp = sr.ReadLine().Split(',');
                    string candidate = temp[0];
                    int votes = int.Parse(temp[1]);
                    if (dic.ContainsKey(candidate))
                    {
                        dic[candidate] += votes;
                    }
                    else
                    {
                        dic[candidate] = votes;
                    }
                }
            }

            foreach(KeyValuePair<string, int> el in dic)
            {
                Console.WriteLine(el.Key + ": " + el.Value);
            }
        }
    }
}
