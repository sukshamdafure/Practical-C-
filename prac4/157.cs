using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString = "your_connection_string_here";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT GETDATE()", conn);
            Console.WriteLine(cmd.ExecuteScalar());
        }
    }
}