using System.Data.SqlClient;
using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.IO.Pipelines;

namespace AdoNet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string connectionString = "server=localhost;uid=root;pwd=220178;database=akademi";

                MySqlConnection pipe = new MySqlConnection();//connection object. 



                pipe.ConnectionString = connectionString;//assigns connections string

                pipe.Open();//opens connection

                string sql = "select * from afdeling";//the query
                //string sql = "insert into afdeling(AfdelingNavn, AfdelingChef) values('Physics', 'Martin Z')";

                MySqlCommand cmd = new MySqlCommand(sql, pipe);//command object and parameters

                MySqlDataReader reader = cmd.ExecuteReader();//reader object. 

                while (reader.Read())//loop table using reader method. 
                {
                    Console.WriteLine("ID: " + reader.GetString(0) + " " + "Navn: " + reader.GetString(1) + " " + "Chef: " + reader.GetString(2));
                }
                pipe.Close();// closes connection
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
           
        }

    }
}