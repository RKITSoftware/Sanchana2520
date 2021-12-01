using MVC_WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_WebApplication.Controllers
{
    public class CollegeInfoController : Controller
    {
        // GET: CollegeInfo
        public ActionResult DisplayData()
        {
            CollegeInfo obj = new CollegeInfo(); //creating object

            //creating list 
            obj.ListOfCollege();

            //passing the content to view
            return View(obj);
           
        }
    }
}