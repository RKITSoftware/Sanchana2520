using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiple_inheritance
{
    public interface Interface1
    {
        void msg1(); 
    }
    public interface Interface2
    {
        void msg2();
    }
    class ImplementInterafce : Interface1, Interface2 //multiple inheritance
    {
        public void msg1()
        {
            Console.WriteLine("msg1 method is implemented"); //implementing mehtod of first interface
        }
        public void msg2()
        {
            Console.WriteLine("msg2 method is implemented"); //implementing mehtod of second interface
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            ImplementInterafce obj = new ImplementInterafce(); //creating object
            //calling the methods
            obj.msg1();
            obj.msg2();
          
            Console.ReadKey();
        }
    }
}
