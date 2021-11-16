using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_demo
{
    class Program
    {
        public enum studentlist //enum
        {
            Sanchana, heni, nency = 1, riddhi, dharmishtha
        } 
        static void Main(string[] args)
        {
            string[] student_values = Enum.GetNames(typeof(studentlist)); //retriving the names
            int total = 0;
            foreach (string s in student_values) //traversing through the enum 
            {
                Console.WriteLine(s);
                total++;
            }
            Console.WriteLine("Total number of students are : {0}", total); //displaying total number of students
            Console.WriteLine();

            int[] total_students = (int[])Enum.GetValues(typeof(studentlist)); //getting the values 
            foreach (int n in total_students)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();    
        }
    }
}
