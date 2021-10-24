using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_demo
{
     sealed class Program
     {
         // Calling Function
         public int Add(int a, int b)
         {
             return a + b;
         }
    
    
        static void Main(string[] args)
        {
            // Creating an object of Sealed Class
           Program obj = new Program();

            // Performing Addition operation
            int addition = obj.Add(10, 52);
            Console.WriteLine("Total = " + addition.ToString());
        }
    }
}
