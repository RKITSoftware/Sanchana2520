using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_prog
{
    class calculation
    {

        // Declaring the delegate
        public delegate void SampleDelegate();
        //Declaring an event
        public event SampleDelegate SampleEvent;
        public void Add(int a, int b)
        {
            // Calling event delegate to check subscription
            if (SampleEvent != null)
            {
                // Raise the event by using () operator
                SampleEvent();
                Console.WriteLine("Adding the Result: {0}", a + b);
            }
            else
            {
                Console.WriteLine("Not Subscribed to Event");
            }
        }
        public void Subtract(int x, int y)
        {
            // Calling event delegate to check subscription
            if (SampleEvent != null)
            {
                // Raise the event by using () operator
                SampleEvent();
                Console.WriteLine("Subtract Result: {0}", x - y);
            }
            else
            {
                Console.WriteLine("Not Subscribed to Event");
            }
        }
    }
    class Operations
    {
        calculation obj;

        public int a { get; set; }
        public int b { get; set; }
        public Operations(int x, int y)
        {
            obj = new calculation();
            // Subscribe to SampleEvent event
            obj.SampleEvent += SampleEventHandler;
            a = x;
            b = y;
        }
        // SampleEvent Handler
        public void SampleEventHandler()
        {
            Console.WriteLine("SampleEvent Handler: Calling Method");
        }
        public void AddOperation()
        {
            obj.Add(a, b);
        }
        public void SubOperation()
        {
            obj.Subtract(a, b);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Operations obj_op = new Operations(50, 7); //creating object

            //calling methods
            obj_op.AddOperation();
            obj_op.SubOperation();

            Console.ReadKey();
        }
    }
}

