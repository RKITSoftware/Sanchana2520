using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedlist_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //creation of sortedlist  
            SortedList<int, string> sortedlist = new SortedList<int, string>();
            //add the elements in sortedlist  
            sortedlist.Add(1, "Sanchana");
            sortedlist.Add(2, "Heni");
            sortedlist.Add(3, "Nency");
            sortedlist.Add(4, "Riddhi");
            

             //display the elements of the sortedlist  
            Console.WriteLine("The elements in the SortedList are:");
            foreach (KeyValuePair<int, string> pair in sortedlist)
            {
                Console.WriteLine("{0} ==> {1}", pair.Key, pair.Value);
            }

            //Find the capacity  
            Console.WriteLine("The capacity is:" + sortedlist.Capacity);
            sortedlist.Add(5, "Shanaya");
            sortedlist.Add(6, "Shibu");
            Console.WriteLine("After adding two more element the capacity is:" + sortedlist.Capacity);

            //count
            Console.WriteLine("The total number of students in the sortedlist are:" + sortedlist.Count); 

            //contains
            Console.WriteLine("The key 1 contain in the SortedList:" + sortedlist.ContainsKey(1));

            //contain value
            Console.WriteLine("The value Sanchana contain in the SortedList:" + sortedlist.ContainsValue("Sanchana"));

            //shows the index key
            Console.WriteLine("The index value of the key 2 is:" + sortedlist.IndexOfKey(2)); 
 
            //show the index value
            Console.WriteLine("The index value of the value nency is:" + sortedlist.IndexOfValue("Nency"));

            //remove the elements from the sortedlist  
            sortedlist.Remove(1);  
            Console.ReadKey();
        }

    }
}
