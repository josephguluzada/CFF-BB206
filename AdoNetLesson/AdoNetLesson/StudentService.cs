using System.Data.SqlClient;

namespace AdoNetLesson;

internal static class StudentService
{
    public static void InsertData(string query)
    {
        string connectionString = "Server=CATALYST\\SQLEXPRESS;Database=StoreDBBB206;Trusted_Connection=True;";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {

            connection.Open();

            SqlCommand command = new SqlCommand($"INSERT INTO Students VALUES ({query})", connection);

            int affectedRows = command.ExecuteNonQuery();

            if (affectedRows > 0)
            {
                Console.WriteLine("Data Inserted");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }

    public static void DeleteData()
    {
        string connString = "Server=CATALYST\\SQLEXPRESS;Database=StoreDBBB206;Trusted_Connection=True";

        using (SqlConnection connection = new SqlConnection(connString))
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM Students WHERE Id=8", connection);

            int affectedRows = sqlCommand.ExecuteNonQuery();

            if (affectedRows > 0)
                Console.WriteLine("Data Deleted");
            else
                Console.WriteLine("Error");
        }


    }

    public static void GetData(string sqlQuery, int id)
    {
        string connString = "Server=CATALYST\\SQLEXPRESS;Database=StoreDBBB206;Trusted_Connection=True";

        using (SqlConnection connection = new SqlConnection(connString))
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand($"{sqlQuery} WHERE Id={id}", connection);

            string fullName = (string)sqlCommand.ExecuteScalar();

            Console.WriteLine(fullName);

        }
    }

    public static void GetAllDatas()
    {
        string connString = "Server=CATALYST\\SQLEXPRESS;Database=StoreDBBB206;Trusted_Connection=True";

        using (SqlConnection connection = new SqlConnection(connString))
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM Students", connection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    Console.WriteLine($"{sqlDataReader[0]}- {sqlDataReader[1]} - {sqlDataReader[2]}- {sqlDataReader[3]}");
                }
            }
        }
    }
}
