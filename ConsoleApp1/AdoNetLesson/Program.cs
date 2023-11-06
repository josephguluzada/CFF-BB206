using System.Data.SqlClient;

namespace AdoNetLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InsertData();
            //GetAllDatas();
            GetData();
        }

        static void GetData()
        {
            string connectionString = "Server=CATALYST\\SQLEXPRESS;Database=UniversityDB;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT Fullname FROM Students WHERE Id=23", connection);

                string fullName = (string)command.ExecuteScalar();

                Console.WriteLine(fullName);
            }
        }

        static void GetAllDatas()
        {
            string connectionString = "Server=CATALYST\\SQLEXPRESS;Database=UniversityDB;Trusted_Connection=True;";


            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Students", sqlConnection);

                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while(reader.Read())
                    {
                        Console.WriteLine($"{reader[0]} - {reader[1]}");
                    }
                }
            }
        }


        static void InsertData()
        {
            string connectionString = "Server=CATALYST\\SQLEXPRESS;Database=UniversityDB;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("Insert into students values ('Test Testov', 22,999,1)", connection);

                int affectedRow = sqlCommand.ExecuteNonQuery();

                if (affectedRow > 0)
                {
                    Console.WriteLine("Inserted");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
        }
    }
}