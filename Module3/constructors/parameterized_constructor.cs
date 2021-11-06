using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameterized_constructor
{
    class Program
    {
       public  int a, b;
       public string name;
      public Program(int x, int y,string z)  // decalaring Paremetrized Constructor with int x,y parameter
        {
            a = x;
            b = y;
            name = z;
        }
        static void Main(string[] args)
        {
            Program obj = new Program(10,20,"Sanchana"); //calling the parameterized constructor
            Console.WriteLine("value of a=" + obj.a);
            Console.WriteLine("value of b=" + obj.b);
            Console.WriteLine("String is=" + obj.name);

            Console.ReadKey();
        }
    }
}
