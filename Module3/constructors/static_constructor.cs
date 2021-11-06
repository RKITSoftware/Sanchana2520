using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_constructor
{
    class Program
    {
         // Static constructor
        static Program()
        {
            Console.WriteLine("This is static constructor");
            
        }
        public static void detail() //static method
        {
            Console.WriteLine("This is detail method");
        }
        class new_program
        {
            static void Main(string[] args)
            {
                Program.detail();
                Console.ReadKey();
            }
        }
    }
}
