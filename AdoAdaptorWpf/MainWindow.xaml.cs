using AdoAdaptorWpf.Afdelings;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AdoAdaptorWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MySqlDataAdapter? mySqlDataAdapter;
        private DataSet? ds;
        public MainWindow()
        {
            InitializeComponent();
        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                string connectionString = "server=localhost;uid=root;pwd=220178;database=sql_hr";
                MySqlConnection con = new MySqlConnection(connectionString);
                con.Open();
                string sql_command = "select * from employees";
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
                mySqlDataAdapter.Fill(ds, "employees");

                //Update datagrid
                dpt.ItemsSource = ds.Tables[0].DefaultView;
                

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            //apply changes to database.
            try
            {
                //reuse dataAdapter and dataset
                mySqlDataAdapter.Update(ds, "employees");
                MessageBox.Show("Update successful!");
            }
            catch (Exception m)
            {
                MessageBox.Show(m.ToString());
            }
        }
    }
}
