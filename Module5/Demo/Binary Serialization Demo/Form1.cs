using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary_Serialization_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Serialize_Click(object sender, EventArgs e)
        {
           Student obj = new Student
            {
                name =textBoxName.Text,
                city = textBoxCity.Text,
                college = textBoxCollege.Text,
                dob = dateTimePicker1.Value,
               
            };

            //BinaryFormatter to serialize the object in BinaryFormat.
            BinaryFormatter obj_bf = new BinaryFormatter();

            //Make a file using FileStream 
            FileStream obj_out = new FileStream("student.binary", FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
                using (obj_out)
                {
                    //bf.Serialize(obj_out, emp) will serialize the object "obj" and store it in file "employee.binary"
                    obj_bf.Serialize(obj_out, obj);
                    label5.Text = "Object has been Serialized";
                }
            }
            catch
            {
                label5.Text = "Error";
            }
        }

        //click event for Deserialize button. 
        //When clicking on the Deserialize button,deserialize the object and show its values on screen
        private void Deserialize_Click(object sender, EventArgs e)
        {
            Student obj1 = new Student();

            //BinaryFormatter to serialize the object in BinaryFormat.
            BinaryFormatter obj_bf = new BinaryFormatter();

            FileStream obj_in = new FileStream("student.binary", FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                using (obj_in)
                {
                    //deserialize the object
                    obj1 = (Student)obj_bf.Deserialize(obj_in);
                    label5.Text = "Object Deserialized";

                    textBoxName.Text = obj1.name;
                    textBoxCity.Text = obj1.city;
                    dateTimePicker1.Value = obj1.dob;
                }
            }
            catch
            {
                label5.Text = "Error";
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
