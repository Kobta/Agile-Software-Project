using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class MealsD
    {
        //connection
        public string ConSt = "server=localhost;user id=root;database=agileproject;sslmode=None";
        MySqlConnection connection = new MySqlConnection();

        DataTable dt = new DataTable();

        //get everything inside planned meals
        public DataTable Read()
        {
            connection.ConnectionString = ConSt;
            if (ConnectionState.Closed == connection.State)
                connection.Open();
            MySqlCommand cmd = new MySqlCommand("select name, productionDate from meal", connection);
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
