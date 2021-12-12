using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class AddRecipeD
    {
        //connection
        public string ConSt = "server=localhost;user id=root;database=agileproject;sslmode=None";
        MySqlConnection connection = new MySqlConnection();

        //textboxes
        public int Insert(string name, string ctg, int aop, string inst)
        {
            connection.ConnectionString = ConSt;
            if (ConnectionState.Closed == connection.State)
                connection.Open();
            MySqlCommand cmd = new MySqlCommand("insert into recipe (name, category, AmountOfPortions, Instructions) values ('"+name+"','"+ctg+"','"+aop+"', '"+inst+"')", connection);
            try
            {
               int res = cmd.ExecuteNonQuery();
                return res;
            }
            catch
            {
                throw;
            }
        }
        //ingredients inside datagrid
        public int Insert(ObservableCollection<IngredientsListItem> GridIngredients)
        {
            connection.ConnectionString = ConSt;
            if (ConnectionState.Closed == connection.State)
                connection.Open();

            //Create papameters for the query
            MySqlCommand cmd = new MySqlCommand("insert into recipe_ingr (amount, unitType) values  (@Amount, @UnitName)", connection);
            //There needs to be a parameter, before it can be given a value
            cmd.Parameters.Add("@Ingredient", MySqlDbType.String);
            cmd.Parameters.Add("@Amount", MySqlDbType.Int32);
            cmd.Parameters.Add("@UnitName", MySqlDbType.String);
            try
            {
                //check that datagrid values are not null and delete one row since its always empty
                for (int i = 0; i <= GridIngredients.Count - 1 && GridIngredients[i] != null; i++ )
                {
                    //give value to parameters by getting every value inside datagrid in order
                    cmd.Parameters["@Ingredient"].Value = GridIngredients[i].Ingredient.ToString();
                    cmd.Parameters["@Amount"].Value = Convert.ToInt32(GridIngredients[i].Amount);
                    cmd.Parameters["@UnitName"].Value = GridIngredients[i].UnitName.ToString();
                    cmd.ExecuteNonQuery();
                }
                //this worked
                return 1;
            }
            catch
            {
                throw;
            }
        }
    }
}
