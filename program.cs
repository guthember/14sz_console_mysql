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

            string query = "SELECT * FROM nevek";

            List<string>[] list = new List<string>[3];
            list[0] = new List<string>(); // id
            list[1] = new List<string>(); // nev 
            list[2] = new List<string>(); // cim

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                list[0].Add(dataReader["nevid"] + "");
                list[1].Add(dataReader["nev"] + "");
                list[2].Add(dataReader["cim"] + "");
            }

            dataReader.Close();

            for (int i = 0; i <= list.Length; i++)
            {
                Console.WriteLine(list[0][i]+" "+list[1][i].ToString().PadRight(20)+
                    " "+list[2][i].ToString().PadRight(40));
            }

            
            connection.Close();

            Console.ReadKey();
        }
    }
}
