using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashtable_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            //adding elements
            ht.Add("1", "Java");
            ht.Add("2", "C#");
            ht.Add("3", "c++");
            ht.Add("4", "AJS");

            ICollection key = ht.Keys;

            Console.WriteLine("Retrieving all elements: ");
            Console.WriteLine();
            foreach (var k in key)
            {
                Console.WriteLine(k + ":" + ht[k]);
            }
            ArrayList array_list = new ArrayList(key);
            Console.WriteLine("Retrieving all keys in the arraylist");
            Console.WriteLine();
            foreach (var n in array_list)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();  
        }
    }
}
