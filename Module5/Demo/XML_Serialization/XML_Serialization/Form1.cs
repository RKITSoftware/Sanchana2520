using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace XML_Serialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Creating click event
        private void Serialize_Click(object sender, EventArgs e)
        {     
            Student obj = new Student
            {
                name = textBoxName.Text,
                city = textBoxCity.Text,
                college = textBoxCollege.Text,
                dob = dateTimePicker1.Value,
                msg = "No serialization required"
            };

            //XmlSerializer to serialize the object in XML format.
            XmlSerializer obj_xml = new XmlSerializer(typeof(Student));

            //Make a file using FileStream 
            FileStream obj_out = new FileStream("student.xml", FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
                using (obj_out)
                {
                    //serializing the object
                    obj_xml.Serialize(obj_out, obj);
                    label5.Text = "Object Serialized";
                }
            }
            catch
            {
                label5.Text = "Error";
            }
        }

        private void Deserialize_Click(object sender, EventArgs e)
        {
            Student obj = new Student();

            ////XmlSerializer to serialize the object in XML format.
            XmlSerializer obj_xml = new XmlSerializer(typeof(Student));

            //Make a file using FileStream 
            FileStream obj_in = new FileStream("student.xml", FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                using (obj_in)
                {
                    //deserialize the object
                    obj = (Student)obj_xml.Deserialize(obj_in);
                    label5.Text = "Object Deserialized";

                    textBoxName.Text = obj.name;
                    textBoxCity.Text = obj.city;
                    textBoxCollege.Text = obj.college;
                    dateTimePicker1.Value = obj.dob;
                    
                }
            }
            catch
            {
                label5.Text = "An error has occured";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
