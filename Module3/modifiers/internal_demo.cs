using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internal_modifier
{
    class Program
    {
        class Internal_modifier
        {
            
            internal string city = "Jamnagar";
            internal void Welcome(string message)
            {
                Console.WriteLine("Hi " + message);
            }
        }
        static void Main(string[] args)
        {
            Internal_modifier obj = new Internal_modifier();//creating object

            Console.WriteLine("Hello " + obj.city);  // Accessing internal variable
            obj.Welcome("Welcome");  // Accessing internal function  
            Console.ReadKey();
        }
    }
}
