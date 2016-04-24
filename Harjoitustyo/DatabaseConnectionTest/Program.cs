﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace DatabaseConnectionTest
{
class Program
    {
        static void Main(string[] args)
        {

            MySqlConnection conn;

            string myConnectionString = "Server=mysql.labranet.jamk.fi;" +
                "Database=K1697_2;" +
                "Uid=K1697;" +
                "Pwd=0MuzjwiZvKIpLmB0snwNRuFLPSqYjfxn;";

            try
            {
                conn = new MySqlConnection(myConnectionString);
                conn.Open();
                Console.WriteLine("Connection successful");

                MySqlCommand command = conn.CreateCommand();
                //command.CommandText = "SHOW TABLES;";
                //command.CommandText = "SELECT * FROM game;";
                command.CommandText = "SHOW COLUMNS FROM game;";
                MySqlDataReader Reader;
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    string row = "";
                    for (int i = 0; i < Reader.FieldCount; i++)
                        row += Reader.GetValue(i).ToString() + ", ";
                    Console.WriteLine(row);
                }

                conn.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

           
            
            /*SqlConnection testConnection = new SqlConnection();
            testConnection.ConnectionString =
                "Server=mysql.labranet.jamk.fi;" +
                "Database=K1697;" +
                "Uid=K1697;" +
                "Pwd=0MuzjwiZvKIpLmB0snwNRuFLPSqYjfxn;";


            Console.WriteLine("Kappa");
            testConnection.Open();
            Console.WriteLine("Claus");*/
            /*try
            {
                Console.WriteLine("Trying to connect to SQL-database");
                Console.WriteLine("Connected");
            } catch(SqlException ex)
            {
                Console.WriteLine("Error occurred: " + ex.Message);
            }*/

        }
    }
}
