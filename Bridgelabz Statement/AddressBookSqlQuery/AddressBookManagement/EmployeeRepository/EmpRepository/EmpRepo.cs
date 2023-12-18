using EmployeeModels;
using EmployeeRepository.IEmpRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRepository.EmpRepository
{
    public class EmpRepo : IEmpRepo
    {
        private SqlConnection con;
        private void connection()
        {
            string connectionstr = "data source = (localdb)\\MSSQLLocalDB; initial catalog = EmployeeManagement; integrated security = true";
            con = new SqlConnection(connectionstr);
        }
        public Employee AddEmployee(Employee obj)
        {
            try
            {
                connection();
                SqlCommand com = new SqlCommand("AddEmployee", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@name", obj.Name);
                com.Parameters.AddWithValue("@city", obj.City);
                com.Parameters.AddWithValue("@Address", obj.Address);
                con.Open();
                com.ExecuteNonQuery();
                return obj;
                //var i = com.ExecuteScalar();
                //if (i != null)
                //{
                //    Console.WriteLine("Database added");
                //    obj.EmpId = Convert.ToInt32(i);
                //    Console.WriteLine(obj.EmpId);
                //    return obj;
                //}
                //else
                //{
                //    return null;
                //}
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
        public bool DeleteEmployee(int empid)
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
        public Employee UpdateEmployee(Employee obj)
        {
            try
            {
                connection();
                SqlCommand com = new SqlCommand("UpdateEmployee", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Id", obj.EmpId);
                com.Parameters.AddWithValue("@Name", obj.Name);
                com.Parameters.AddWithValue("@City", obj.City);
                com.Parameters.AddWithValue("@Address", obj.Address);
                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();
                if (i != 0)
                {
                    return obj;
                }
                else
                {
                    return null;
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
        public List<Employee> GetAllEmployee()
        {
            connection();
            List<Employee> emplist = new List<Employee>();
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
                    new Employee
                    {
                        EmpId = Convert.ToInt32(dr["Empid"]),
                        Name = Convert.ToString(dr["name"]),
                        City = Convert.ToString(dr["city"]),
                        Address = Convert.ToString(dr["Address"])
                    }
                    );
            }
            foreach (var data in emplist)
            {
                Console.WriteLine(data.EmpId + " " + data.Name + " " + data.City + " " + data.Address);
            }
            return emplist;
        }
        public Employee GetEmployeeData(int empid)
        {
            connection();
            Employee emp = new Employee();
            SqlCommand com = new SqlCommand("GetEmployeeData", con);
            com.Parameters.AddWithValue("@id", empid);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            emp.EmpId = Convert.ToInt32("Empid");
            emp.Name = Convert.ToString("name");
            emp.City = Convert.ToString("city");
            emp.Address = Convert.ToString("Address");
            return emp;
        }
    }
}
