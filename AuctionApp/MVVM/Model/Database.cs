using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AuctionApp.MVVM.Model
{
    class Database
    {
        MySqlConnection connection;

        public Database()
        {
            connection = new MySqlConnection();
        }

        public MySqlConnection getConnection()
        {
            string connectionString = "SERVER=localhost;DATABASE=auctionappdb;UID=root;PASSWORD=";

            try
            {
                connection.ConnectionString = connectionString;
                connection.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return connection;
        }

        ~Database()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }

        }
    }
}
