using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi_demo.Models
{
    public class Student_info
    {
        #region Public variables

        /// <summary>
        /// primary key StudentID 
        /// </summary>
        [Key]
        public int StudentID { get; set; }

        /// <summary>
        /// Field for StudentName 
        /// </summary>
       
        public string StudentName { get; set; }

        /// <summary>
        /// Field for Subject
        /// </summary>
        public string Subject { get; set; }
        
        #endregion Public Variables
    }
}
