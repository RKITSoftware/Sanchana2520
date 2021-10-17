using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    class Program
    {
        public void while_loop() {
            int x = 1;

            //while loop

            // Exit when x becomes greater than 5
            while (x <= 5)
            {
                Console.WriteLine("While loop");

                // Increment the value of x for
                // next iteration
                x++;
            }

            }
        public void do_while()
        {

            //do....while(nested)
            int i = 0;

            do //first loop
            {
                Console.WriteLine("Value of i: {0}", i);
                int j = i;

                i++; //incrementing the value

                do //second loop
                {
                    Console.WriteLine("Value of j: {0}", j);
                    j++; //incrementing value
                } while (j < 3); // checking condition for second loop

            } while (i < 3);// checking condition for first loop
         
        }

        public void for_loop()
        {
            //for loop
            Console.Write("Enter a number: "); 
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i < n; i++) //traversing in for loop
            {
                for (int j = 1; j <= i; j++) 
                Console.Write(j);
                Console.WriteLine();
            }
            for (int i = n; i >= 0; i--) 
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(j);
                Console.WriteLine();
            }
        }

        public void foreach_loop()
    {
        
            //foreach

            char[] gender = { 'm', 'f', 'm', 'm', 'm', 'f', 'f', 'm', 'm', 'f' };
            int male = 0, female = 0;
            foreach (char g in gender) //traversing in foreach loop
            {
                if (g == 'm') //checking the condition
                    male++;
                else if (g == 'f')
                    female++;
            }
            Console.WriteLine("Number of male = {0}", male);
            Console.WriteLine("Number of female = {0}", female);
    }
        static void Main(string[] args)
        {


            objProgram obj = new Program(); //creating object

            //calling all methods
            obj.while_loop();
            obj.do_while();
            obj.for_loop();
            obj.foreach_loop();
            Console.ReadKey();

         

        }
    }
}
