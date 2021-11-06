using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copy_constructor
{
    class student
    {
        string name,city;
        // declaring Copy constructor.
        public student(student stu)   
        {
            name = stu.name;
            city = stu.city;
        }

        public student(string name, string city)  // Instance constructor.
        {
            this.name = name;
            this.city = city;
        }
        public string Details     
        {
            get
            {
                return  " The name is: " + name + " \n The city is: " + city;

            }
        }
        static void Main(string[] args)
        {
            student obj1 = new student("Sanchana", "Jamnagar");  // Create a new  object.
            student obj2 = new student(obj1);          // here is obj1 details is copied to obj2.
            Console.WriteLine(obj2.Details);
            Console.ReadLine();
        }
    }
}
