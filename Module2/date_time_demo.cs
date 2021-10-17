using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date_time_demo
{
    class Program
    {
        static void Main(string[] args)
        {

            int days = 0;
            int ret = 0;
            bool flag = false;

            days = DateTime.DaysInMonth(2016, 2); //used to get number of days in given month of year

            Console.WriteLine("Day in Month : " + days);

            flag = DateTime.IsLeapYear(2016); // used to find given year is leap year or not

            if (flag == true)
                Console.WriteLine("\nGiven year is leap year");

            else
                Console.WriteLine("\nGiven year is not leap year");

            Console.WriteLine("Current DateTime :" + DateTime.Now.ToString());

            DateTime d1 = new DateTime(2017, 6, 10);
            DateTime d2 = new DateTime(2017, 6, 11);

            flag = DateTime.Equals(d1, d2); //used to check given dates objects are equal or not.

            if (flag == true)
                Console.WriteLine("Given dates are equal");
            else
                Console.WriteLine("Given dates are not equal");

            ret = DateTime.Compare(d1, d2); // used to check given dates objects are equal or not

            if (ret > 0)
                Console.WriteLine("First date is greater");
            else if (ret < 0)
                Console.WriteLine("Second date is greater");
            else
                Console.WriteLine("Given dates are equal");

            // adding and subtracting date time
            DateTime dt = new DateTime(2019, 2, 22, 14, 0, 0);

            DateTime dt1 = dt.AddSeconds(45);
            DateTime dt2 = dt.AddMinutes(30);
            DateTime dt3 = dt.AddHours(72);
            DateTime dt4 = dt.AddDays(65);
            DateTime dt5 = dt.AddDays(-65);
            DateTime dt6 = dt.AddMonths(3);
            DateTime dt7 = dt.AddYears(4);

            Console.WriteLine(dt1.ToString("F"));
            Console.WriteLine(dt2.ToString("F"));
            Console.WriteLine(dt3.ToString("F"));
            Console.WriteLine(dt4.ToString("F"));
            Console.WriteLine(dt5.ToString("F"));
            Console.WriteLine(dt6.ToString("F"));
            Console.WriteLine(dt7.ToString("F"));


            //----code for properties----
            string[] months = {"January", "February", "March", "April", "May","June", "July", "September", "October", "November", "December"};
            DateTime now = DateTime.Now;

            Console.WriteLine("Today's date: {0}", now.Date); //shows current date
            Console.WriteLine("Today is {0} day of {1}", now.Day, months[now.Month - 1]);
            Console.WriteLine("Today is {0} day of {1}", now.DayOfYear, now.Year); // shows current day of year
            Console.WriteLine("Today's time: {0}", now.TimeOfDay);//shows time of day
            Console.WriteLine("Hour: {0}", now.Hour); 
            Console.WriteLine("Minute: {0}", now.Minute);
            Console.WriteLine("Second: {0}", now.Second);
            Console.WriteLine("Millisecond: {0}", now.Millisecond);
            Console.WriteLine("The day of week: {0}", now.DayOfWeek); //shows day of week
            Console.WriteLine("Kind: {0}", now.Kind);

            
            Console.ReadKey();
        }
    }
}
