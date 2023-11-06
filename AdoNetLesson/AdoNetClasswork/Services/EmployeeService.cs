using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetClasswork.Services
{
    public class EmployeeService
    {
        public static void GetDataById(int id)
        {

            string connectionString = "Server=CATALYST\\SQLEXPRESS;Database=StoreDBBB206;Trusted_Connection=true;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand($"SELECT Name FROM Employees WHERE Id={id}", connection);
                string name = (string)command.ExecuteScalar();

                Console.WriteLine(name);
            }
        }
        
        public static void Update(string updatedSetValue, int id)
        {
            string connectionString = "Server=CATALYST\\SQLEXPRESS;Database=StoreDBBB206;Trusted_Connection=true;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand($"UPDATE Employees SET {updatedSetValue} WHERE Id={id}", connection);
                int affectedRows = command.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    Console.WriteLine("Data Updated!");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }

        }

    }
}
