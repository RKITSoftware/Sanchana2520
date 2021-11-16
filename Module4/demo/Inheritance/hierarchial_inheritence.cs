using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heirarchial_inheritance
{
     class Parent  //Parent class    
    {
        public void msg1()
        {
            Console.WriteLine( "this is Parent class Method");
        }
    }
    class Child1 : Parent //child 1 class
    {
        public void msg2()
        {
            Console.WriteLine("this is child1 class Method");  
        }
    }
      class Child2 : Parent //child 2 class
        {
            public void msg3()
            {
                Console.WriteLine("this is child2 class Method");
            }
        }
        
    class Program
    {
        static void Main(string[] args)
        {
            Child2 obj = new Child2(); //object for second class
            //calling functions
            obj.msg1();
            obj.msg3();

            //Child1 can't be called using Child2's object, so a new object has to be created
            Child1 obj1 = new Child1();
            obj1.msg2();

            Console.ReadKey();
        }
    }
}
