using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack < string > stack1 = new Stack < string > ();  
            
            stack1.Push("IT");  
            stack1.Push("Civil");  
            stack1.Push("Mechanical");  
            stack1.Push("Computer");  
            
            Console.WriteLine("The courses in the stack1 are as:");  
            foreach(string s in stack1) {  
                Console.WriteLine(s);  
            }

            //elelment at top
            Console.WriteLine("Peek element: " + stack1.Peek());

            //pop an element
            Console.WriteLine("Pop: " + stack1.Pop());

            Console.WriteLine("After Pop, the Peek element: " + stack1.Peek());

            //check whether stack contains civil
            Console.WriteLine("Contains 'civil' :" + stack1.Contains("Civil"));

            Console.ReadKey();
        
        }
    }
}
