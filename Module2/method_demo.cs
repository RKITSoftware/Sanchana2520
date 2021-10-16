using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_demo
{
    class Program
    {   string name, city;
        int age;

        public void details()
        {
            Console.Write("Enter your name:");
            name = Console.ReadLine();

            Console.Write("Enter your city name:");
            city= Console.ReadLine();

            Console.Write("Enter your Age:");
            age = Convert.ToInt32(Console.ReadLine());
        }

        public void display()
        {    //displaying the details
            Console.WriteLine("\nYour details:");
            Console.WriteLine("Name:" + name);
            Console.WriteLine("City:" + city);
            Console.WriteLine("Age:" + age);
           
        }

        //call by ref
        public void number(ref int contact_new)
        {
            Console.WriteLine("Contact number:" + contact_new);
            Console.ReadLine();
             }

        // call by value
        public void marks(int month_1, int month_2)
        {

            Console.WriteLine("Entered salary:");
            Console.WriteLine("Salary in January:" + month_1 + "\nSalary in February:" + month_2);
            Console.ReadLine();
        }

        //return values in method
        public int sum(int salary1, int salary2)
        {
            return salary1 + salary2;
           
        }
         
        //optional
        public void add(int num1, int num2=5)
        {
            Console.WriteLine(num1 + num2);  
        }
           
            
        static void Main(string[] args)
        {
            Program obj = new Program();
            // method calling
            obj.details();
            obj.display();

            //----code for call by reference----
            char n;

            Console.WriteLine("Enter your contact number:");
            int contact_no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your contact number is:" + contact_no);
            Console.WriteLine("Do you want to make any changes?(Y/N)");

            n = Console.ReadKey().KeyChar;
            if (n == 'Y')
             {
                Console.WriteLine("\nEnter new contact number:");
                int new_contact = Convert.ToInt32(Console.ReadLine());
                obj.number(ref new_contact); //calling by reference
            }
            else
            {
                Console.WriteLine("Please fill other details");
            }

            //----code for call by value----
            Console.WriteLine("Enter your salary for 2 months: ");

            Console.Write("January:");
            int month1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("February:");
            int month2 = Convert.ToInt32(Console.ReadLine());

            obj.marks(month1, month2); //calling by value
            Console.WriteLine("Sum of the salary:" + obj.sum(month1,month2));//Return value method

            //----code for optional argument----
            obj.add(1, 2); // Passing both arguments  
            obj.add(10);    // Passing only required argument  

            Console.ReadLine();
        }
    }
}
