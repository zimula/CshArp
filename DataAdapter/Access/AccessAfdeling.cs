using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAdapter.Access
{
    internal class AccessAfdeling
    {
        //moving adapter and dataset to class, for reuse in other method
        private MySqlDataAdapter mySqlDataAdapter;
        private DataSet dataset;

        

        public void accessEmps()
        {
            try
            {
                string connectionString = "server=localhost;uid=root;pwd=220178;database=akademi";
                MySqlConnection pip = new MySqlConnection(connectionString);

                string command = "select * from afdeling";

                MySqlCommand mySqlCommand = new MySqlCommand(command, pip);

                //command builder
                MySqlCommandBuilder mySqlBuilder = new MySqlCommandBuilder();
                
                //dataAdapter (moved to class)
                //MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
                mySqlDataAdapter = new MySqlDataAdapter();
               
                //associatebuilder with adapter
                mySqlBuilder.DataAdapter = mySqlDataAdapter;

                //specify select command
                //the adaptor will use it to generate update, insert etc. 
                mySqlDataAdapter.SelectCommand = mySqlCommand;

                //create dataset (moved to class)
                dataset = new DataSet();
                
                
                //use adapter to populate dataset 
                mySqlDataAdapter.Fill(dataset, "afdeling");

                //loop through dataset
                foreach (DataTable table in dataset.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        foreach (DataColumn column in table.Columns)
                        {
                            Console.WriteLine(row[column]);

                        }
                        Console.WriteLine("====================================================================================");
                    }
                }
                pip.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public void updateAfdeling()
            //this method will let you manipulate the database. 
        {
            try
            {
                mySqlDataAdapter.Update(dataset,"afdeling");
                Console.WriteLine("Update Successful");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
