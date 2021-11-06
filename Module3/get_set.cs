using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace get_set_demo
{
    class student
    {
       
            //Getter and setter is used to set or get value.
            public static string name { get; set; }
            public static int rollno { get; set; }
            public static string city { get; set; }
        }

    class student_info{
        static void Main(string[] args)
        {
            //set the value.
            student.name = "Nadar Sanchana";
            student.rollno = 7;
            student.city = "jamnagar";

            //get the value.
            Console.WriteLine("The details of student are:");
            Console.WriteLine("Name : " + student.name);
            Console.WriteLine("Roll no.: " + student.rollno);
            Console.WriteLine("City: " + student.city);
            Console.ReadLine();
        }
    }
    
}
