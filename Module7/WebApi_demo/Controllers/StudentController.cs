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

        StudentBL obj_bl = new StudentBL();
   
        [HttpGet]
        public List<StudentBL> Get()
        {
            return (obj_bl.selectAll());
        }

      
        //retrieving data
        public StudentBL Get(int id)
        {
            return (obj_bl.retrieve_data(id));
        }

        /// <summary>
        /// Insert studentData.
        /// </summary>
        /// <param name="learning">
        /// </param>
        /// <returns>
        /// return a string messages.
        /// </returns>
        
        [HttpPost]
        public void Post([FromBody] Student_info learning)
        {
            obj_bl.insertStudent(learning);
        }

        /// <summary>
        /// Update student Data.
        /// </summary>
        /// <param name="learning">
        /// </param>
        /// <returns>
        /// return a string messages.
        /// </returns>
        [HttpPut]
        public void Put([FromBody] Student_info learning)
        { 
            obj_bl.updateStudent(learning);
        }

        /// <summary>
        /// Delete studentData.
        /// </summary>
        /// <param name="learning">
        /// </param>
        /// <returns>
        /// return a string messages.
        /// </returns>
       
        [HttpDelete]
        public void Delete(int id)
        {
            obj_bl.deleteStudent(id);
        }
    }
}
