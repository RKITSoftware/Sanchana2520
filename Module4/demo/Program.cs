using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    class Program
    {
        void array_exception()
        {
            try
            {
                int[] n = new int[5] { 66, 33, 56, 23, 81 };
                int i, j;
                // error: IndexOutOfRangeException
                for (j = 0; j < 10; j++)
                {
                    Console.WriteLine("Element[{0}] = {1}", j, n[j]);
                }
            }
            catch (System.IndexOutOfRangeException e) //catching the exception
            {
                Console.WriteLine(e);
            }

        }

        void divide_by_zero()
        {
            Console.Write("Please enter a number to divide 100: ");

            try
            {
                int num = int.Parse(Console.ReadLine());

                int result = 100 / num;

                Console.WriteLine("100 / {0} = {1}", num, result);
            }
            catch (DivideByZeroException ex) //will catch the exception
            {
                Console.Write("Cannot divide by zero. Please try again.");
            }

        }

        void ArgumentOutOfRange()
        {
            var list = new List<string>();
            list.AddRange(new String[] { "C", "C++", "C#" });
            try
            {
                // Display the elements in the list by index.
                for (int i = 0; i <= list.Count; i++)
                {
                    Console.WriteLine("Index {0}: {1}", i, list[i]);
                }
            }

            catch (ArgumentOutOfRangeException e) //catch block 
            {
                Console.WriteLine("Exception:" + e.Message);
            }

            finally //finally block
            {
                Console.WriteLine("Finally block.");
                Console.ReadLine();
            }


        }

        void KeyNotFound()
        {

            try
            {
                var dictionary = new Dictionary<string, string>()   //declare a dictionary
                {
                        {"Java", "PHP"},
                        {"AJS", "Python"},
                };
                // the invalid key
                Console.WriteLine(dictionary["C"]);
            }
            catch (Exception e)
            {
                 Console.WriteLine("Exception:" + e.Message);// The Message property of the object
               
            }

        }
        void NullRefernce()
        {
            string str = null; //declare a string
            try
            {
                Console.WriteLine(str.Substring(2)); //try to access substring of null
            }
            catch (NullReferenceException e)
            {
                //message after catching the exception
                Console.WriteLine("Please check the string.");
                Console.WriteLine("Exception occured:" + e.Message);
                
            }
        }

        void InvalidCastException()
        {
            int intNum = 123;
            object Obj;

            Obj = intNum;
            try
            {
                Console.WriteLine("Unboxing a integer number");
                int num = (short)Obj;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        static void Main(string[] args)
        {
            Program obj = new Program(); //creating object

            //calling all methods
            obj.array_exception();
            obj.divide_by_zero();
            obj.ArgumentOutOfRange();
            obj.KeyNotFound();
            obj.NullRefernce();
            obj.InvalidCastException();


            Console.ReadKey();
        }
    }
}