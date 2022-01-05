using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;
using System.Web;
using WebApi_demo.Models;
using MySqlConnector;

namespace WebApi_demo.BL
{
    public class StudentBL
    {
        #region Public Variables

        public static string ConnectionString = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;

        #endregion Public Variables

        #region Public Methods

        //Creating a list and retrieve data
        public List<Student_info> selectAll()
        {
            //create a list 
            List<Student_info> obj_student = new List<Student_info>();

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
                            obj_student.Add(new Student_info()
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
        /// <summary>
        /// Get Student information
        /// </summary>
        /// <param name="id">id is a unique identifier</param>
        /// <returns>will return a student record</returns>
        //retrive data by id
        public Student_info retrieve_data(int id)
        {
            Student_info obj_student = new Student_info();

           //create MySql connection
            using (MySqlConnection obj_con = new MySqlConnection(ConnectionString))
            {
                try
                {
                    //open connection
                    obj_con.Open();
                    MySqlCommand obj_cmd = new MySqlCommand("select * from Student where StudentID = " + id + ";", obj_con);

                    using (var reader = obj_cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                              obj_student.StudentID = Convert.ToInt32(reader["StudentID"]);
                              obj_student.StudentName = reader["StudentName"].ToString();
                              obj_student.Subject = reader["Subject"].ToString();
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
        /// <summary>
        /// insert method used to insert teh student
        /// </summary>
        /// <param name="learning">learning is an object of Student_info</param>
        /// <returns>Message for success of operation </returns>
        public string insertStudent(Student_info learning)
        {
            List<Student_info> obj_student = new List<Student_info>();

           //create MySql connection
            using (MySqlConnection obj_con = new MySqlConnection(ConnectionString))
            {
                try
                {
                    obj_con.Open(); //open connection

                    //insert query
                    MySqlCommand obj_cmd = new MySqlCommand("insert into Student (StudentID,StudentName,Subject) values('" + learning.StudentID + "','" + learning.StudentName + "','" + learning.Subject + "';", obj_con);

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

        /// <summary>
        /// Update method used to update the student data
        /// </summary>
        /// <param name="learning">learning is an object of Student_info</param>
        /// <returns>Message for success of operation </returns>
        public string updateStudent(Student_info learning)
        {
            List<Student_info> obj_student = new List<Student_info>();

            //create MySql connection
            using (MySqlConnection obj_con = new MySqlConnection(ConnectionString))
            {
                try
                {
                    obj_con.Open(); //open connection

                    //query to update
                    MySqlCommand obj_cmd = new MySqlCommand("update Student set StudentID= '" + learning.StudentID + "',StudentName = '" + learning.StudentName + "', Subject = '" + learning.Subject + "' where StudentID = '" + learning.StudentID + "';", obj_con);

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
        /// <summary>
        ///Delete method used to delete student data
        /// </summary>
        /// <param name="id">id is a unique identifier</param>
        /// <returns>Message for Success of operation </returns>
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
