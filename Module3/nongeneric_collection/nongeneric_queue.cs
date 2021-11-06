using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace non_generic_queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue1 = new Queue();
            queue1.Enqueue("Sanchana"); //adding elements in queue
            queue1.Enqueue("Nency");
            queue1.Enqueue(7);
            queue1.Enqueue(7.1);

            foreach (var elements in queue1)
            {
                Console.Write(elements);
            }

            //Element at the top
            Console.WriteLine("Element at the top is: " + queue1.Peek());

            //Does it contain no. 21
            Console.WriteLine("Contain number 7: " + queue1.Contains(7));

            queue1.Dequeue(); //removing element

            //contains a specific element
            Console.WriteLine("Contain word Sanchana after dequeue: " + queue1.Contains("Sanchana"));

            Console.ReadKey();
        }
    }
}
