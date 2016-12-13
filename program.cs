using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace caNevek
{
    class Program
    {
        static private MySqlConnection connection;
        static private string server;
        static private string database;
        static private string uid;
        static private string password;


        static void Main(string[] args)
        {

            server = "localhost";
            database = "proba";
            uid = "root";
            password = "";

            string connectionString = 
                "SERVER=" + server + ";" + 
                "DATABASE=" + database + ";" + 
                "UID=" + uid + ";" + 
                "PASSWORD=" + password + ";";

            //Console.WriteLine(connectionString);

            connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                Console.WriteLine("Sikeres");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Sikertelen");
            }

            connection.Close();

            Console.ReadKey();
        }
    }
}
