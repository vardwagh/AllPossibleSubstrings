using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPossibleSubstrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            List<string> l = new List<string>();

            Console.WriteLine("Enter a string: ");
            str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                StringBuilder newString = new StringBuilder();
                for (int j = i; j < str.Length; j++)
                {
                    newString.Append(str[j]);
                    Console.Write(newString + " ");
                    l.Add(newString.ToString());
                }
            }

            var noDupes = l.Distinct().ToList();
            int longest = noDupes.OrderByDescending(s => s.Length).First().Length;


            Console.ReadLine();

        }
    }
}
