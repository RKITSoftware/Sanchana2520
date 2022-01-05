using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_demo.Models;
using WebApi_demo.BL;

namespace WebApi_demo.Controllers
{
   
    public class StudentController : ApiController
    {
        /// <summary>
        /// Get student Data.
        /// </summary>
        /// <returns>
        /// return student Data.
        /// </returns>

        StudentBL obj_db = new StudentBL();
    
        public List<StudentBL> Get()
        {
            return (obj_db.selectAll());
        }

      
        //retrieving data
        public StudentBL Get(int id)
        {
            return (obj_db.retrieve_data(id));
        }

        /// <summary>
        /// Insert studentData.
        /// </summary>
        /// <param name="learning">
        /// </param>
        /// <returns>
        /// return a string messages.
        /// </returns>

        public void Post([FromBody] Student_info learning)
        {
            obj_db.insertStudent(learning);
        }

        /// <summary>
        /// Update student Data.
        /// </summary>
        /// <param name="learning">
        /// </param>
        /// <returns>
        /// return a string messages.
        /// </returns>
        public void Put([FromBody] Student_info learning)
        { 
            obj_db.updateStudent(learning);
        }

        /// <summary>
        /// Delete studentData.
        /// </summary>
        /// <param name="learning">
        /// </param>
        /// <returns>
        /// return a string messages.
        /// </returns>
       
        public void Delete(int id)
        {
            obj_db.deleteStudent(id);
        }
    }
}
