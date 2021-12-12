using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class RecipeD
    {
        public string ConSt = "server=localhost;user id=root;database=applicationproject;sslmode=None";
        MySqlConnection connection = new MySqlConnection();

        DataTable dt = new DataTable();

        public DataTable Read()
        {
            connection.ConnectionString = ConSt;
            if (ConnectionState.Closed == connection.State)
                connection.Open();
            MySqlCommand cmd = new MySqlCommand("select name, category, AmountOfPortions, id from recipe", connection);
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
        public DataTable Read(string nm)
        {
            connection.ConnectionString = ConSt;
            if (ConnectionState.Closed == connection.State)
                connection.Open();
            MySqlCommand cmd = new MySqlCommand("select name FROM recipe WHERE name like '%" + nm + "%'", connection);
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

        public string Read(int id)
        {
            connection.ConnectionString = ConSt;
            if (ConnectionState.Closed == connection.State)
                connection.Open();
            MySqlCommand cmd = new MySqlCommand("select instructions FROM recipe WHERE id like '%" + id + "%'", connection);
            try
            {
                MySqlDataReader rd = cmd.ExecuteReader();
                string result="";
                while (rd.Read())
                {
                   result = rd.GetString(0);
                }
                return result;
            }
            catch
            {
                throw;
            }
        }
        public DataTable Read(string nm, DateTime v)
        {
            connection.ConnectionString = ConSt;
            if (ConnectionState.Closed == connection.State)
                connection.Open();

            MySqlCommand cmd = new MySqlCommand("insert into meals (name, productionDate) values '%" + nm + "%','%" + v + "%'", connection);
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
