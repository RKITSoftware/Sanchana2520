using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist_demo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ArrayList array_list = new ArrayList();
            array_list.Add(1);
            array_list.Add("sanchana");
            array_list.Add(1.1);
            

            string second_Element = (string)array_list[1]; //returns "sanchana"
            
            Console.WriteLine(second_Element);

            //using var keyword without explicit casting
            var firstValue = array_list[0]; //returns 1
            var secondValue = array_list[1]; //returns "sanchana"
            Console.WriteLine(firstValue);
            Console.WriteLine(secondValue);

            //update elements
            array_list[0] = 2;

            //insert an element at particular index
            array_list.Insert(1, "Second");

            foreach (var val in array_list)
            {
                Console.Write(val);
            }

            
            //Removes element at index 4
            array_list.RemoveAt(3);
            //Removes two elements starting from 1st item (0 index)
            array_list.RemoveRange(0, 2);

            foreach (var val in array_list)
                Console.Write(val);

            Console.WriteLine(array_list.Contains("sanchana"));
            Console.ReadLine();
        }
    }
}
