using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    internal static class DatabaseConnection
    {
        private static string connectionString = "";

        public static SqlConnection getConnection()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                return connection;
            }
        }

        public static DataSet getData(String query)
        {

            using (SqlConnection connection = getConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();

                adapter.Fill(dataSet);

                connection.Close();
                return dataSet;
            }
        }

        public static void setData(String query, String message)
        {
            using (SqlConnection connection = getConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                command.ExecuteNonQuery();
                connection.Close();

                if (message != "")
                    MessageBox.Show("'" + message + "'", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
