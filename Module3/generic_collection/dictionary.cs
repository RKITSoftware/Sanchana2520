using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a dictionary with string key and Int16 value pair
            Dictionary<string, Int16> StudentList = new Dictionary<string, Int16>();
            StudentList.Add("Sanchana", 1);
            StudentList.Add("Dharmishtha", 2);
            StudentList.Add("Nency", 3);
            StudentList.Add("Riddhi", 4);
            StudentList.Add("Heni", 5);
            // Count
            Console.WriteLine("Count: {0}", StudentList.Count);

            // Set Item value
            StudentList["Shanaya"] = 7;
            if (!StudentList.ContainsKey("Shibu"))
            {
                StudentList["Nency"] = 10;
            }
            if (!StudentList.ContainsValue(45))
            {
                Console.WriteLine("Student not found");
            }

            // Read all items
            Console.WriteLine("Student List:");

            foreach (KeyValuePair<string, Int16> student in StudentList)
            {
                Console.WriteLine("Key: {0}, Value: {1}", student.Key, student.Value);
            }

            // Remove item 
            StudentList.Remove("Sanchana");

            // Remove all items
            StudentList.Clear();
            Console.ReadKey();

      
    }

        
    }
}
