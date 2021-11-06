using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue1 = new Queue<string>();
            queue1.Enqueue("IT");
            queue1.Enqueue("Civil");
            queue1.Enqueue("Mechanical");
            queue1.Enqueue("Computer");
            Console.WriteLine("The Courses in the queue are:");
            foreach (string s in queue1)
            {
                Console.WriteLine(s);
            }

            queue1.Dequeue(); //Removes the first element that enter in the queue 
            queue1.Dequeue(); //Removes civil
            Console.WriteLine("After removal the courses in the queue are:");
            foreach (string s in queue1)
            {
                Console.WriteLine(s);
            }

            //element at top
            Console.WriteLine("Peek element: " + queue1.Peek());

            //checks whether queue contain IT
            Console.WriteLine("Does numbers contain IT:" + queue1.Contains("IT"));
            Console.ReadKey();

        }
        }
}
