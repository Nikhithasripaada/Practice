using System;
using System.Linq;
using System.Collections.Generic;
namespace List_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var vijay = new List<string>();
            vijay.Add("theri");
            vijay.Add("thupaki");
            vijay.Add("jilla");
            vijay.Add("master");
            Console.WriteLine(vijay[0]);
            Console.WriteLine(vijay[2]);
            Console.WriteLine(vijay[3]);
            Console.WriteLine(vijay[1]);
            vijay.Remove("jilla");
            Console.WriteLine(vijay.Contains("thupaki"));
            /* for (int i = 0; i < vijay.Count; i++)
                 Console.WriteLine(vijay[i]);
             vijay.ForEach(num => Console.WriteLine(num + " \t "));*/

            //dictionary
            var employee = new Dictionary<string, string>() {
                {"n","ns" }
            };
            Console.WriteLine(employee["n"]);
        }
    }
}
