using System;
using System.Data;
using System.Data.SqlClient;

public static class DatabaseHelper
{
    private static string connectionString = "Server=DESKTOP-92CN8CS\\SQLEXPRESS;Database=BibliotecaDB;Integrated Security=True;";

    public static DataTable ExecuteQuery(string query)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }

    public static void ExecuteNonQuery(string query)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}
