using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilevel_inheritance
{
    public class Parent //parent class
    {
        public void msg_parent() 
        { 
            Console.WriteLine("This is from Parent class"); 
        }
    }
    public class Child : Parent //child class
    {
        public void msg_child() 
        { 
            Console.WriteLine("This is from Child class"); 
        }
    }
    public class subchild : Child //second child class
    {
        public void msg_subchild()
        { 
            Console.WriteLine("This is from Subchild class");
        }
    }  
    class Program
    {
        static void Main(string[] args)
        {
            subchild obj = new subchild(); //creating object for second child

            //calling all methods
            obj.msg_parent();
            obj.msg_child();
            obj.msg_subchild();

            Console.ReadKey();
        }
    }
}
