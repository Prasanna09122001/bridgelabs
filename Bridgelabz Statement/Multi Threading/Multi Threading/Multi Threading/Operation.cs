using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Threading
{
    public class Operation
    {
        private SqlConnection con;
        private void connection()
        {
            string connectionstr = "data source = (localdb)\\MSSQLLocalDB; initial catalog = EmployeeManagement; integrated security = true";
            con = new SqlConnection(connectionstr);
        }
        public void Addemployeee(person obj)
        {
            try
            {
                connection();
                SqlCommand com = new SqlCommand("AddEmployee", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@name", obj.name);
                com.Parameters.AddWithValue("@city", obj.city);
                com.Parameters.AddWithValue("@Address", obj.address);
                con.Open();
                com.ExecuteNonQuery();
                Console.WriteLine("Database added");
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
        public bool deletemployeee(int empid)
        {
            try
            {
                connection();
                SqlCommand com = new SqlCommand("DeleteEmployee", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@id", empid);
                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();
                if (i != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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
        public void UpdateEmployee(person obj)
        {
            try
            {
                connection();
                SqlCommand com = new SqlCommand("UpdateEmployee", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Id", obj.empid);
                com.Parameters.AddWithValue("@Name", obj.name);
                com.Parameters.AddWithValue("@City", obj.city);
                com.Parameters.AddWithValue("@Address", obj.address);
                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close(); 
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
        public void GetAllEmployee()
        {
            connection();
            List<person> emplist = new List<person>();
            SqlCommand com = new SqlCommand("GetAllEmployee", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            foreach (DataRow dr in dt.Rows)
            {
                emplist.Add(
                    new person
                    {
                        empid = Convert.ToInt32(dr["Empid"]),
                        name = Convert.ToString(dr["name"]),
                        city = Convert.ToString(dr["city"]),
                        address = Convert.ToString(dr["Address"])
                    }
                    );
            }
            foreach (var data in emplist)
            {
                Console.WriteLine(data.empid + " " + data.name + " " + data.city + " " + data.address);
            }
        }

    }
}
