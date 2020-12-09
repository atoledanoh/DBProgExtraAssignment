using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace ExtraAssignment
{
    public class EmployeeOrders : NorthwindRepo
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;

        public DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                    try
                    {
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                    catch (SqlException e)
                    {

                    }
            }
            catch (Exception e)
            {

            }
            return dt;
        }

        public DataTable GetEmployees()
        {
            string sql = ("Select EmployeeId, LastName From Employees ORDER BY EmployeeId");
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (SqlException e)
            {

            }
            return dt;
        }

        public DataTable GetOrders(int id)
        {
            string sql = ($"Select * FROM Orders WHERE EmployeeId = {id} ORDER BY OrderId;");
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (SqlException e)
            {

            }
            return dt;
        }
    }
}
