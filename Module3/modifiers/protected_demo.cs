using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protected_modifier
{
    class Program
    {
        class protected_modifier
        {
            protected string city = "Jamnagar";
            protected void Welcome(string welcome)
            {
                Console.WriteLine("Hello " + welcome);
            }
        }
        static void Main(string[] args)
        {
            protected_modifier obj= new protected_modifier();
            // Accessing protected variable  
            Console.WriteLine("Hi " + obj.city);

            // Accessing protected function  
            obj.Welcome("Welcome");
            Console.ReadKey();
        }

        
    }

}
