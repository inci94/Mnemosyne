using System;
using Microsoft.Data.SqlClient;

//================================================================
//MNEMOSYNE PROJECT - Art History Databasse Connector
//Developer: İnci Ateşoğlu
//This application lists the artworks in the SQL Server databse.
//================================================================

namespace ConsolApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //We are defining the database connection information.
            string connectionString = "Server=PEARL\\MSSQLSERVER01; Database=Mnemosyne; Integrated Security=True; TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //We use a tray-catch block for error checking.
                try
                {
                    //Our SQL Query: We are selecting the work title,artists and period information.
                    connection.Open();
                    string query = "SELECT Title, Artist, Period FROM Artworks";
                    SqlCommand command = new SqlCommand(query, connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //We readeach row in the database one by one. 
                        while (reader.Read())
                        {
                            //We print th read data to the screen in a formatted manner.
                            Console.WriteLine($"{reader["Title"]} - {reader["Artist"]} ({reader["Period"]})");
                        }
                    }
                }
                catch (Exception ex)
                {
                    //If an error occurs, we notify the user. 
                    Console.WriteLine("Hata: " + ex.Message);
                }
            }
            Console.ReadLine();
        }
    }
}

