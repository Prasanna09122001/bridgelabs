using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpace
{
    public class SQLQuery
    {
        public void CreateDataBase()
        {
            SqlConnection con = new SqlConnection("data source = (localdb)\\MSSQLLocalDB; initial catalog=master; integrated Security= true");
            try
            {
                string query = "Create Database MySpace";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("DataBase Created Sucessfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There is no database created " + ex);
            }
            finally
            {
                con.Close();
            }
        }
        public static SqlConnection con = new SqlConnection("data source = (localdb)\\MSSQLLocalDB; initial catalog=MySpace; integrated Security= true");
        public void CreatePersonalDetailstable()
        {
            try
            {
                string query = "Create table PersonalDetails(id int primary key identity(1,1),Name varchar(30),Email varchar(20),PhoneNumber varchar(10),College varchar(30));";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table Created Sucessfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There is no Table created " + ex);
            }
            finally
            {
                con.Close();
            }
        }
       
        public void AddDetails(Details detail)
        {
            try
            {
                SqlCommand com = new SqlCommand("AddPersonalDetails", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Name", detail.Name);
                com.Parameters.AddWithValue("@Email", detail.Email);
                com.Parameters.AddWithValue("@PhoneNumber", detail.PhoneNumber);
                com.Parameters.AddWithValue("@College", detail.college);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("Contact Added");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void GetAllDetails()
        {
            List<Details> details = new List<Details>();
            SqlCommand com = new SqlCommand("GetDetails", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            foreach (DataRow dr in dt.Rows)
            {
                details.Add(
                   new Details
                   {
                       Id = Convert.ToInt32(dr["id"]),
                       Name = Convert.ToString(dr["Name"]),
                       Email = Convert.ToString(dr["Email"]),
                       PhoneNumber = Convert.ToString(dr["PhoneNumber"]),
                       college = Convert.ToString(dr["College"])
                   }
                   );
            }
            foreach (var data in details)
            {
                Console.WriteLine(data.Id + " " + data.Name + " " + data.Email + " " + data.PhoneNumber + " " + data.college);
            }
        }
       
        public void DeleteDetails(int id)
        {
            try
            {
                SqlCommand com = new SqlCommand("DeleteDetails", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@id",id);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("Contact Removed");
                GetAllDetails();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void UpdateDetails(Details Detail)
        {
            try
            {
                SqlCommand com = new SqlCommand("UpdateDetails", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Id", Detail.Id);
                com.Parameters.AddWithValue("@Name", Detail.Name);
                com.Parameters.AddWithValue("@Email", Detail.Email);
                com.Parameters.AddWithValue("@PhoneNumber", Detail.PhoneNumber);
                com.Parameters.AddWithValue("@College", Detail.college);
                con.Open();
                int i = com.ExecuteNonQuery();
                Console.WriteLine("Data Updated");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void PersonalDetail()
        {
            Details Detail = new Details();
            Console.WriteLine("Enter your Name");
            Detail.Name = Convert.ToString(Console.Read());
            Console.WriteLine("Enter your Email Id");
            Detail.Email = Convert.ToString(Console.Read());
            Console.WriteLine("Enter your Phone Number");
            Detail.PhoneNumber = Convert.ToString(Console.Read());
            Console.WriteLine("Enter your College Name");
            Detail.college = Convert.ToString(Console.Read());
            AddDetails(Detail);
        }
        public void DeleteDetail()
        {
            Console.WriteLine("Enter the Id Number of the person to be Removed");
            int number = Convert.ToInt32(Console.Read());
            DeleteDetails(number);
        }
        public void UpdateDetail()
        {
            Details Detail = new Details();
            Console.WriteLine("Enter the Id number to be Updated");
            Detail.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Name of Person To be Updated");
            Detail.Name = Convert.ToString(Console.Read());
            Console.WriteLine("Enter your Email Id");
            Detail.Email = Convert.ToString(Console.Read());
            Console.WriteLine("Enter your Phone Number");
            Detail.PhoneNumber = Convert.ToString(Console.Read());
            Console.WriteLine("Enter your College Name");
            Detail.college = Convert.ToString(Console.Read());
            UpdateDetails(Detail);
        }
    }
}
 