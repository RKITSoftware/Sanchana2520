using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_inheritance
{
   public class parent //parent class
   {
       public void msg()
       {
           
           Console.WriteLine("This is parent class");
       }  
   }
    public class child : parent //single inheritance
    {
        public void msg1()
        {
            Console.WriteLine("This is child class");
        }  
    }
    class Program
    {

        public static void Main(string[] args)
        {
            child obj = new child(); //creating object of child class
            obj.msg(); //calling parent method
            obj.msg1();//calling child method

            Console.ReadKey();
        }
    }
}
