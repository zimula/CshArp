using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using MySql.Data.MySqlClient;

namespace AdoAdaptorWpf.Afdelings
{
    internal class Afdeling
    {
        private MySqlDataAdapter? mySqlDataAdapter;
        private DataSet? ds;
        
        
        public void accessAfd()
        {
            try
            {
                string connectionString = "server=localhost;uid=root;pwd=220178;database=akademi";
                MySqlConnection con = new MySqlConnection(connectionString);
                string sql_command = "select * from afdeling";
                MySqlCommand orders = new MySqlCommand(sql_command, con);
                //command builder
                MySqlCommandBuilder mysqlbuilder = new MySqlCommandBuilder();
                //
                mySqlDataAdapter = new MySqlDataAdapter();
                //associate builder with adapter
                mysqlbuilder.DataAdapter = mySqlDataAdapter;
                //specify select command
                mySqlDataAdapter.SelectCommand = orders;
                //create dataset
                ds = new DataSet();
                //populate dataset
                mySqlDataAdapter.Fill(ds,"afdeling");

                //send to gui:
               


                //loop through data set
                foreach (DataTable table in ds.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        foreach (DataColumn column in table.Columns)
                        {
                            MessageBox.Show("helo");
                        }
                    }
                }
                con.Close();

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }
        
    }
}
