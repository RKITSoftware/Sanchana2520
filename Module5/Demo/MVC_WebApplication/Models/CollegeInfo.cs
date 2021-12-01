using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_WebApplication.Models
{
    public class College
    {
        public int sr_no;
        public String Name;
        public String City;

    }
    public class CollegeInfo
    {//create a list
        public List<College> listCollege { get; set; }

        //list method
        public void ListOfCollege()
        {
            listCollege = new List<College>();

            //creating object and adding information
            College obj_College = new College();
            obj_College.sr_no = 1;
            obj_College.Name = "Atmiya University";
            obj_College.City = "Rajkot";

            //add colleges to the list
            listCollege.Add(obj_College);

            //Adding another detail
            obj_College = new College();
            obj_College.sr_no = 1;
            obj_College.Name = "Atmiya University";
            obj_College.City = "Rajkot";

            //adding more details
            listCollege.Add(obj_College);

            obj_College = new College();
            obj_College.sr_no = 2;
            obj_College.Name = "GEC";
            obj_College.City = "Rajkot";

            listCollege.Add(obj_College);

            obj_College = new College();
            obj_College.sr_no = 3;
            obj_College.Name = "Marwadi";
            obj_College.City = "Rajkot";

            listCollege.Add(obj_College);




        }
    }
}