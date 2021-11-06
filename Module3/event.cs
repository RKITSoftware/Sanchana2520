using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_demo
{
    public delegate string demoDelegate(string str1, string str2); //delegate

    class event_prog

    {   event demoDelegate myEvent; //creating event

        public event_prog() 
        {
        this.myEvent += new demoDelegate(this.Display);
     }

     public string Display(string studentname, string subject)
     {
        return "Student: " + studentname + "\nSubject: " +subject;
     }
     static void Main(string[] args)
     {

         event_prog obj = new event_prog(); //creating object
         string display = obj.myEvent("Sanchana", "Science");
         Console.WriteLine("Detail:" + display); //displaying detail
     }
    }
}
