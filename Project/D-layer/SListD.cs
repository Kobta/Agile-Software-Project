using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class SListD
    {
        //connection
        public string ConSt = "server=localhost;user id=root;database=agileproject;sslmode=None";
        MySqlConnection connection = new MySqlConnection();

        DataTable dt = new DataTable();

        //get everything inside shoppinglist
        public DataTable Read()
        {
            connection.ConnectionString = ConSt;
            if (ConnectionState.Closed == connection.State)
                connection.Open();
            MySqlCommand cmd = new MySqlCommand("select items, executionDate from shoppinglist", connection);
            try
            {
                MySqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch
            {
                throw;
            }

        }
    }
}
