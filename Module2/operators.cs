using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_and_expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
         

            // Arithmetic operators

            Console.WriteLine("Entered number:" + number);  // number entered by user
            number++; // Postfix increment operator
            Console.WriteLine("Number after postfix increment:"+ number);   // number after postfix increment

            Console.WriteLine("Prefixed increment number:" + (++number)); // Prefix increment operator

            number--; // Postfix decrement operator
            Console.WriteLine("Number after postfix decrement:"+ number);   // number after postfix decrement

            Console.WriteLine("Number after prefix decrement:" + (--number)); // Prefix decrement

            number += 10; // compound assignment
            Console.WriteLine("Adding 10 to resultant number:" + number);
            
            Console.WriteLine("\nAddition operator:" + (5 + 15)); //addition operator
            Console.WriteLine("Subtraction operator:" + (1 - 5)); //subtraction operator
            Console.WriteLine("Multiplication operator:" + (1.5 * 1.8)); //multiplication operator
            Console.WriteLine("Division operator:" + (10.5f / 1.1f)); //division operator
            Console.WriteLine("Remainder operator:" + (-5.2f % 5.0f)); //remainder operator
            
            //Comparision operators

            Console.WriteLine("\n------Comparision operator -------");
            Console.WriteLine(1.1 < 10.1); // less than operator (returns true or false)
            Console.WriteLine(1.1 > 10.1); // greater than operator(returns true or false) 
            Console.WriteLine(2.6 <= 7.5); //less than or equal to operator
            Console.WriteLine(10.1 >= 7.7); //greater than or equal to operator


            //Boolean logical operator

            bool passed = true;
            Console.WriteLine(!passed);  //negation operator
            Console.WriteLine(!true);


            //Bitwise operator
            int a = 60; /* 60 = 0011 1100 */
            int b = 13; /* 13 = 0000 1101 */
            int c = 0;
            // Bitwise AND Operator
            c = a & b; /* 12 = 0000 1100 */
            Console.WriteLine("Line 1 - Value of c is {0}", c);
            // Bitwise OR Operator
            c = a | b; /* 61 = 0011 1101 */
            Console.WriteLine("Line 2 - Value of c is {0}", c);
            // Bitwise XOR Operator
            c = a ^ b; /* 49 = 0011 0001 */
            Console.WriteLine("Line 3 - Value of c is {0}", c);
            // Bitwise Complement Operator
            c = ~a; /*-61 = 1100 0011 */
            Console.WriteLine("Line 4 - Value of c is {0}", c);
            // Bitwise Left Shift Operator
            c = a << 2; /* 240 = 1111 0000 */
            Console.WriteLine("Line 5 - Value of c is {0}", c);
            // Bitwise Right Shift Operator
            c = a >> 2; /* 15 = 0000 1111 */
            Console.WriteLine("Line 6 - Value of c is {0}", c);

            //Ternery operator
            int x = 1, y = 10;

            var result = x > y ? "x is greater than y" : "x is less than y"; //condition checking through ternery operator

            Console.WriteLine(result);

            //Assignment operator
            
            int num1 = 7;
            int num;
            num = num1;
            Console.WriteLine("Line 1 - =  Value  = {0}", num);

            num += num1;
            Console.WriteLine("Line 2 - += Value = {0}", num);

            num -= num1;
            Console.WriteLine("Line 3 - -=  Value = {0}", num);

            num *= num1;
            Console.WriteLine("Line 4 - *=  Value  = {0}", num);

            num /= num1;
            Console.WriteLine("Line 5 - /=  Value = {0}", num);

            num <<= 2;
            Console.WriteLine("Line 6 - <<=  Value  = {0}", num);

            num >>= 2;
            Console.WriteLine("Line 7 - >>=  Value {0}", num);

           

            Console.ReadLine();
        }
    }
}
