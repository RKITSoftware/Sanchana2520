using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break_continue_goto
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            for (i = 0; i <= 10; i++)
            {

                if (i == 5)

                    continue; //jumps out of the current loop condition and jumps back to the starting of the loop code.

                if (i == 7)

                    break;// breaks out of the loop at the current point

                Console.WriteLine(i); //printing the value till 6

            }

            int choice = 3;

            switch (choice)
            {

                case 1:
                    Console.WriteLine("case 1");
                    break;

                case 2:
                    Console.WriteLine("case 2");
                    break;

                case 3:

                    goto case 1;
                    break;
            }
            Console.ReadLine();     
        }
    }
}
