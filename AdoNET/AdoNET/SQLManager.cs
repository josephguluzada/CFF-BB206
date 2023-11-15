using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNET
{
    public static class SQLManager
    {
        private static string _connectionString = "Server=CATALYST\\SQLEXPRESS;Database=StoreDBBB206;Trusted_Connection=True;";
        private static SqlConnection _sqlConnection = null;

        public static SqlConnection SqlConnection 
        {
            get
            {
                if(_sqlConnection is null) return _sqlConnection = new SqlConnection(_connectionString);
                return _sqlConnection;
            }
        }

        public static int Execute(string command)
        {
            int result;
            SqlConnection.Open();

            using (SqlCommand cmd = new SqlCommand(command, SqlConnection))
            {
                 result = cmd.ExecuteNonQuery();
            }

            SqlConnection.Close();

            return result;
        }

        public static DataTable Reader(string command)
        {
            DataTable dataTable = new DataTable();
            SqlConnection.Open();

            using (SqlDataAdapter adapter = new SqlDataAdapter(command,SqlConnection))
            {
                adapter.Fill(dataTable);
            }

            SqlConnection.Close();

            return dataTable;
        }

    }
}
