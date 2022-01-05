using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;
using System.Web;
using WebApi_demo.Models;

namespace WebApi_demo.BL
{
    public class StudentBL
    {
        #region Public Variables

        public static string ConnectionString = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;

        #endregion Public Variables

        #region Public Methods

        //Creating a list and retrieve data
        public List<StudentBL> selectAll()
        {
            //create a list 
            List<StudentBL> obj_student = new List<StudentBL>();

            //create MySql connection
            using (MySqlConnection obj_con = new MySqlConnection(ConnectionString))
            {
                try
                {
                    //open connection
                    obj_con.Open();
                    MySqlCommand obj_cmd = new MySqlCommand("select * from Tutor", obj_con);

                    using (var reader = obj_cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            obj_student.Add(new StudentBL()
                            {
                                StudentID = Convert.ToInt32(reader["StudentID"]),
                                StudentName = reader["StudentName"].ToString(),
                                Subject = reader["Subject"].ToString(),

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Connection cannot be opened" + ex.Message); //shows error

                }

            }
            return obj_student;
        }

        //retrive data by id
        public StudentBL retrieve_data(int id)
        {
            StudentBL obj_student = new StudentBL();

           //create MySql connection
            using (MySqlConnection obj_con = new MySqlConnection(ConnectionString))
            {
                try
                {
                    //open connection
                    obj_conn.Open();
                    MySqlCommand obj_cmd = new MySqlCommand("select * from Student where StudentID = " + id + ";", obj_con);

                    using (var reader = obj_cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                              StudentID = Convert.ToInt32(reader["StudentID"]),
                              StudentName = reader["StudentName"].ToString(),
                              Subject = reader["Subject"].ToString(),
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Connection cannot be opened" + ex.Message);

                }
                finally
                {
                    obj_con.Close();
                }

            }
            return obj_student;
        }

        //Insert data
        public string insertStudent(StudentBL learning)
        {
            List<StudentBL> obj_student = new List<StudentBL>();

           //create MySql connection
            using (MySqlConnection obj_con = new MySqlConnection(ConnectionString))
            {
                try
                {
                    obj_con.Open(); //open connection

                    //insert query
                    MySqlCommand obj_cmd = new MySqlCommand("insert into Student (StudentID,StudentName,Subject) values('" + learning.StudentID + "','" + learning.T
                    StudentName + "','" + learning.Subject + "';", obj_con);

                    int result = obj_cmd.ExecuteNonQuery();

                   //checking condition
                    if (result > 0)
                    {
                        return "successful";
                    }
                    return "Not successfull ";


                }
                catch (Exception ex)
                {
                    return "error" + ex.Message;
                }
                finally
                {
                    obj_con.Close(); //closing connection
                }

            }
        }


        //update data
        public string updateStudent(StudentBL learning)
        {
            List<StudentBL> obj_student = new List<StudentBL>();

            //create MySql connection
            using (MySqlConnection obj_con = new MySqlConnection(ConnectionString))
            {
                try
                {
                    obj_con.Open(); //open connection

                    //query to update
                    MySqlCommand obj_cmd = new MySqlCommand("update countries set  Student (StudentID,StudentName,Subject) values('" + learning.StudentID + "','" + learning.T
                    StudentName + "','" + learning.Subject + "';", obj_con);


                    int result = obj_cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        return "successful";
                    }
                    return "Not successfull ";


                }
                catch (Exception ex)
                {
                    return "error" + ex.Message;
                }
                finally
                {
                    obj_con.Close(); //closing connection
                }

            }
        }

        //delete data
        public string deleteStudent(int id)
        {
            //create MySql connection
            using (MySqlConnection obj_con = new MySqlConnection(ConnectionString))
            {
                try
                {
                    obj_con.Open(); //open connection

                    //query to delete
                    MySqlCommand obj_cmd = new MySqlCommand("delete from Student where id = " + id, obj_con);

                    int result = obj_cmd.ExecuteNonQuery();

                    //checking condition
                    if (result > 0)
                    {
                        return "successful";
                    }
                    return "Not successfull query";


                }
                catch (Exception ex)
                {
                    return "Error " + ex.Message; //showing error
                }
                finally
                {
                    obj_con.Close(); //close connection
                }

            }
        }
        #endregion Public Methods
    }
}
