using MySql.Data.MySqlClient;
using System;
using System.Windows;
using System.ComponentModel;

namespace SQL_APP_001
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DB database = new DB();
        BindingList<Vehicle> vehicles = new BindingList<Vehicle>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void FillButton_Click(object sender, RoutedEventArgs e)
        {
            string sqlQuery = "SELECT * FROM traffic;";

            try
            {
                VehicleListbox.Items.Clear();
                database.conn.Open();
                MySqlCommand cmd = new MySqlCommand(sqlQuery, database.conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    VehicleListbox.Items.Add($"{rdr[1]} : {rdr[2],5}kph");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            database.conn.Close();

        }

        private void PerformQuery(string sqlToRun, params object[] list)
        {
            database.conn.Open();
            MySqlCommand command = new MySqlCommand(sqlToRun,database.conn);
            if (list.Length > 0)
            {
                for(int i = 0; i < list.Length; i += 2)
                {
                    //command.Parameters.AddWithValue()
                }
            }
        }
    }
}
