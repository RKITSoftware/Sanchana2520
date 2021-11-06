using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace private_constructor
{
    class Program
    {
        
        // Variables 
        public static string name; 
        public static int num; 
  
       // Creating private Constructor using private keyword 
        private Program() { 
  
        Console.WriteLine("Welcome to Private Constructor"); 
        } 
  
        // Default Constructor with parameters 
        public Program(string a, int b) { 
  
            name = a; 
            num = b; 
         } 
        class student
        {
            static void Main(string[] args)
            {
                // Program obj = new Program(); // This line raises error because the constructor is inaccessible 

                Program obj = new Program("Sanchana", 7); 
                Console.WriteLine(Program.name + ", " + Program.num); 
                Console.ReadLine();
            }
        }
    }
}
