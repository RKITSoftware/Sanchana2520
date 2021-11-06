using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace public_modifier
{
    class Program
    {
        class AccessMod
        {
            public int num1; //public variable
           
        } 
        static void Main(string[] args)
        {
            AccessMod obj = new AccessMod(); //creating object
            //Direct access to public members  
            obj.num1 = 100;
         
            Console.WriteLine("Number one value in main: {0}", obj.num1);
            Console.ReadLine();
        }
    }
}
