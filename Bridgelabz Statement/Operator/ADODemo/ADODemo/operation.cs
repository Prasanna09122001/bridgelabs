using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODemo
{
    public class operation
    {
        public static void CreateDataBase()
        {
            SqlConnection con = new SqlConnection("data source = (localdb)\\MSSQLLocalDB; initial catalog=master; integrated Security= true");
            try
            {
                string query = "Create Database PersonDetails";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("DataBase Created Sucessfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There is no database created ");
            }
            finally
            {
                con.Close();
            }
        }
        public static SqlConnection con = new SqlConnection("data source = (localdb)\\MSSQLLocalDB; initial catalog=Payroll_Service; integrated Security= true  ");
        public static bool ReadfromDatabase()
        {
            try
            {
               using(con)
                {
                    person model = new person();
                    string query = "select * from employee";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if(reader.HasRows)
                    {
                        Console.WriteLine("------Data-----");
                        while(reader.Read())
                        {
                            model.id = Convert.ToInt32(reader["id"]);
                            model.date = Convert.ToString(reader["Start_date"]);

                            Console.WriteLine("Id : {0}, start_date: {1}", model.id,model.date);
                        }
                    }
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {

                Console.WriteLine("Something went wrong" + ex);
            }
            finally
            {
                con.Close();
            }
            return false;
        }
        public static void updateDatebase()
        {
            try
            {
                string query = "update Person set phonenumber = '11111111' where id =1";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Date updated Suucessfully");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Date Not Updated");
            }
            finally
            {
                con.Close();
            }
        }
        public static void DeleteDataBase()
        {
            try
            {
                string query = "Delete from Person where id=2";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Date updated Suucessfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Date Not Updated");
            }
            finally
            {
                con.Close();
            }
        }

    }
}
