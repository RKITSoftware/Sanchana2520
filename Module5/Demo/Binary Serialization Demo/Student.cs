

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Serialization_Demo
{
    [Serializable] //serializing 
    class Student
    {
        private string Name;
        public string name
        {
            //Getting and setting the value
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        private string City;
        public string city
        {
            //Getting and setting the value
            get
            {
                return City;
            }

            set
            {
               City = value;
            }
        }

        private string College;
        public string college
        {
            //Getting and setting the value
            get
            {
                return College;
            }

            set
            {
                College= value;
            }
        }


        private DateTime DOB;
        public DateTime dob
        {
            //Getting and setting the value
            get
            {
                return DOB;
            }

            set
            {
                DOB = value;
            }
        }

    }
}
