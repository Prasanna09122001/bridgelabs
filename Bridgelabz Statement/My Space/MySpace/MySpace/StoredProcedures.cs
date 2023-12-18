using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpace
{
    public class StoredProcedures
    {
        public static SqlConnection con = new SqlConnection("data source = (localdb)\\MSSQLLocalDB; initial catalog=MySpace; integrated Security= true");

        public void CreateStoredProcedureForAddDetails()
        {
            try
            {
                string query = "Create Procedure AddPersonalDetails(@Name varchar(20),@Email varchar(20),@PhoneNumber varchar(10),@College varchar(20)) As begin Insert into PersonalDetails values(@Name,@Email,@PhoneNumber,@College) End";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Stored Procedure Created Sucessfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There is no Stored Procedure Created " + ex);
            }
            finally
            {
                con.Close();
            }
        }
        public void CreateStoredProcedureForGetDetails()
        {
            try
            {
                string query = "Create Procedure GetDetails As begin Select * from PersonalDetails End";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Stored Procedure Created Sucessfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There is no Stored Procedure Created " + ex);
            }
            finally
            {
                con.Close();
            }
        }
        public void CreateStoredProcedureForDeleteDetails()
        {
            try
            {
                string query = "Create Procedure DeleteDetails(@id int) As begin Delete from PersonalDetails Where id=@id End";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Stored Procedure Created Sucessfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There is no Stored Procedure Created " + ex);
            }
            finally
            {
                con.Close();
            }
        }
        public void CreateStoredProcedureForUpdateDetails()
        {
            try
            {
                string query = "Create Procedure UpdateDetails(@id int,@Name varchar(20),@Email varchar(20),@PhoneNumber varchar(10),@College varchar(20)) As Begin Update PersonalDetails Set Name=@Name,Email=@Email,PhoneNumber=@Phonenumber,College=@College where id=@id End";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Stored Procedure Created Sucessfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There is no Stored Procedure Created " + ex);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
