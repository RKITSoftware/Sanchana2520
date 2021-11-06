using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            int[] array = { 1, 2, 3, 4 };
            int[] newarray = { 5,6,7,8 };

            list.AddRange(array);
            
            foreach (int number in list)
            {
                Console.Write(number + ",");

            }

            Console.WriteLine("\nRemoving number 1:" + list.Remove(1)); //removing number from list

            Console.WriteLine("\nArraylist contains 2:" + list.Contains(2));//whether list contains 2 or not
            list.InsertRange(2, newarray);
            foreach (int number in list)
            {
                Console.Write(number + ",");
            }


            Console.WriteLine("\n Does number 3 exists in the list : " + list.Exists(x => x == 4));  //using exists to find a number in the list
           
            Console.ReadLine();
        }
    }
}
