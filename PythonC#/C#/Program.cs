using System;
using System.Linq;
using System.Collections.Generic;

namespace PythonC_
{
    class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }

        static string Add(string a, string b)
        {
            return a + b;
        }

        static int Sub(int a, int b)
        {
            return a - b;
        }

        static void Main(string[] args)
        {
            // variables and types

            int a = 1;

            string b = "hello DSC!";

            List<int> list = new List<int> { 1, 2, 3 };

            Dictionary<string, string> d = new Dictionary<string, string>
            {
                ["key"]= "value",
                ["key2"] = "value2"
            };

            // lists

            List<int> l = new List<int> { 1, 2, 3, 4, 5 };

            List<int> l2 = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                l2.Add(i * 2);
            }

            l2 = Enumerable.Range(0, 10).Select(num => num * 2).ToList();

            l2.ForEach(e => Console.Write($"{e}, "));
            Console.WriteLine();

            Console.WriteLine($"Last element: {l2.Last()}");
            Console.WriteLine($"2nd and 3rd element: {string.Join(',', l2.GetRange(1, 2))}");

            // if, for, while

            int cnt = -1;
            if (cnt > 100)
            {
                Console.WriteLine("Unreal");
            }
            else if (cnt > 50)
            {
                Console.WriteLine("Hardly possible");
            }
            else
            {
                Console.WriteLine("This will run");
            }

            for (int i = 5; i < 10; i += 2)
            {
                Console.WriteLine(i);
            }

            cnt = 0;
            while (cnt < 10)
            {
                cnt++;
            }

            // functions

            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Add("spam", "eggs"));

            Console.WriteLine(Sub(145, 89));
        }
    }
}
