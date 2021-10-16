using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello"); // declaration and initialization

            sb.Append(" World"); // appending with another word
            Console.WriteLine(sb);

            sb.Insert(5, "c#"); // inserting a new word
            Console.WriteLine("Inserted String: " + sb);

            sb.Replace("c#", " "); //replacing a word
            Console.WriteLine(sb);

            sb.Remove(5, 3); // removes 3 characters from index 5
            Console.WriteLine(sb);

            
            Console.ReadLine();
        }
    }
}
