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
        //connection string
        public string ConSt = "server=localhost;user id=root;database=agileproject;sslmode=None;";
        MySqlConnection connection = new MySqlConnection();

        DataTable dt = new DataTable();

        //populate datagrid with recipes
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

        //get search result
        public DataTable Read(string nm)
        {
            connection.ConnectionString = ConSt;
            if (ConnectionState.Closed == connection.State)
                connection.Open();
            MySqlCommand cmd = new MySqlCommand("select name, category, AmountOfPortions, id FROM recipe WHERE name like '%" + nm + "%'", connection);
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
        //show instructions
        public string Show (string nm)
        {
            connection.ConnectionString = ConSt;
            if (ConnectionState.Closed == connection.State)
                connection.Open();
            MySqlCommand cmd = new MySqlCommand("select instructions FROM recipe WHERE name like '%" + nm + "%'", connection);
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
        //show ingredients
        public DataTable ShowIngredients(int id)
        {
            connection.ConnectionString = ConSt;
            if (ConnectionState.Closed == connection.State)
                connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT recipe_ingr.amount, recipe_ingr.unitType, foodstuff.name FROM recipe INNER JOIN recipe_ingr ON recipe.id = recipe_ingr.recipe_id INNER JOIN foodstuff ON recipe_ingr.ref_ingr_id = foodstuff.id WHERE recipe.id = '"+id+"'", connection);
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

        //insert recipe into meal
        public int Add(string value, string ddt, int id)
        {
            connection.ConnectionString = ConSt;
            if (ConnectionState.Closed == connection.State)
                connection.Open();

            MySqlCommand shoplist = new MySqlCommand("SELECT recipe_ingr.amount, recipe_ingr.unitType, foodstuff.name FROM recipe INNER JOIN recipe_ingr ON recipe.id = recipe_ingr.recipe_id INNER JOIN foodstuff ON recipe_ingr.ref_ingr_id = foodstuff.id WHERE recipe.id = '" + id + "'", connection);
            MySqlCommand cmd = new MySqlCommand("insert into meal (name, productionDate) values ('"+value+"','"+ddt+"')", connection);
            MySqlCommand selectStorageAmount = new MySqlCommand("SELECT baseUNIT FROM foodstuff WHERE name = @Ingredient", connection);
            MySqlCommand buyINGR = new MySqlCommand("INSERT INTO shoppingList (items) VALUES (@Ingredient)", connection);

            selectStorageAmount.Parameters.Add("@Ingredient", MySqlDbType.String);
            buyINGR.Parameters.Add("@Ingredient", MySqlDbType.String);

            try
            {
                StringBuilder str = new StringBuilder();
                var list = new List<IngredientsListItem>();
                IngredientsListItem[] ingredientsList;

                MySqlDataReader rd1 = shoplist.ExecuteReader();

                while (rd1.Read())
                {
                    list.Add(new IngredientsListItem { Amount = rd1.GetInt32(0), UnitName = rd1.GetString(1), Ingredient = rd1.GetString(2) });
                }

                ingredientsList = list.ToArray();
                rd1.Close();

                for (int i = 0; ingredientsList[i] != null && i < ingredientsList.Length-1; i++)
                {
                    selectStorageAmount.Parameters["@Ingredient"].Value = ingredientsList[i].Ingredient.ToString();

                    int storageAmount = selectStorageAmount.ExecuteNonQuery();
                    int neededAmount = ingredientsList[i].Amount;

                    if (neededAmount > storageAmount)
                    {
                        str.Append(ingredientsList[i].Ingredient.ToString() + ", ");
                    }
                }

                str.ToString().TrimEnd(',');
                buyINGR.Parameters["@Ingredient"].Value = str;
                buyINGR.ExecuteNonQuery();

                cmd.ExecuteNonQuery();
                return 1;

            }
            catch
            {
                throw;
            }
        }
    }
}
