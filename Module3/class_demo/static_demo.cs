using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_demo
{
    public static class Program
    {
        // Static Variables
        public static string name;
        public static string college;
        public static int age;
        public static string city;
        // Static Method
        public static void Details()
        {
            Console.WriteLine("Static Method");
        }
    
   
        static void Main(string[] args)
        {   //assigning values to static variables
            Program.name = "Sanchana";
            Program.college = "Atmiya";
            Program.age = 21;
            Program.city = "Jamnagar";

            //Printing the output
            Console.WriteLine("Name: {0}", Program.name);
            Console.WriteLine("College: {0}", Program.college);
            Console.WriteLine("Age: {0}", Program.age);
            Console.WriteLine("City: {0}", Program.city);

            Program.Details();//calling static method

            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
           
        }
    }
}
