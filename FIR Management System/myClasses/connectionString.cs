using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIR_Management_System.myClasses
{
    class connectionString
    {
        public static SqlConnection MySqlConnection;

        public static SqlConnection getConnection()
        {
            if (MySqlConnection == null)
            {
                MySqlConnection = new SqlConnection();
                MySqlConnection.ConnectionString = @"Data Source = .; Initial Catalog = FIR Management System; Integrated Security = True;";
                MySqlConnection.Open();
            }
            return MySqlConnection;
        }
    }
}
