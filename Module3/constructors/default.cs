using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructors_demo
{
    class addition
    {
        
            int a, b,c;
            public addition()   //default contructor
            {
                a = 100;
                b = 175;
                c = a + b;
            }
         
           
            static void Main(string[] args)
            {
                addition obj = new addition(); //an object is created , constructor is called
                Console.WriteLine(obj.a);
                Console.WriteLine(obj.b);
                Console.WriteLine("Addition is:"+obj.c);
                Console.ReadKey();
            }
        
    }
}
