using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectsV12;Initial Catalog=Student;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into student_info values(@Id,@Name,@Age)",con);

            cmd.Parameters.AddWithValue("@Id",int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name",textBox2.Text);
            cmd.Parameters.AddWithValue("@Age",double.Parse(textBox3.Text));


            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Inserted");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectsV12;Initial Catalog=Student;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("update student_info set Name=@Name,Age=@age where Id = @Id ", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Age", double.Parse(textBox3.Text));


            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Updated");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectsV12;Initial Catalog=Student;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete student_info where Id = @Id", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
           

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Deleted");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectsV12;Initial Catalog=Student;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from student_info", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
           
            con.Close();
            
        }
    }

}
