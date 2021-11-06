using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace private_modifier
{
    class Program
    {
        private string name = "Sanchana";//private variable
        private void Message(string message)
        {
            Console.WriteLine("Hi, " + message);
            
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            // Accessing private variable  
            Console.WriteLine("Hello" + obj.name);
            Console.ReadLine();

            // Accessing private function  
            obj.Message("Welcome");
            Console.ReadLine();
        }
    }
}
