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
            MySqlCommand insertRecipeINGR = new MySqlCommand("INSERT INTO recipe_ingr (recipe_id, amount, unitType, ref_ingr_id) VALUES ((SELECT MAX(recipe.id) FROM recipe),(@Amount),(@UnitName), (SELECT id FROM foodstuff WHERE name = @Ingredient));", connection);
            MySqlCommand testINGR = new MySqlCommand("SELECT EXISTS (SELECT name FROM foodstuff WHERE name = (@Ingredient)", connection);
            MySqlCommand insertINGR = new MySqlCommand("INSERT INTO foodstuff (name) values (@Ingredient)", connection);
            MySqlCommand selectStorageAmount = new MySqlCommand("SELECT baseUNIT FROM foodstuff WHERE name = @Ingredient", connection);
            MySqlCommand buyINGR = new MySqlCommand("INSERT INTO shoppingList (items) VALUES (@Ingredient)", connection);
          
          
            //There needs to be a parameter, before it can be given a value
            testINGR.Parameters.Add("@Ingredient", MySqlDbType.String);
            insertINGR.Parameters.Add("@Ingredient", MySqlDbType.String);
            insertRecipeINGR.Parameters.Add("@Amount", MySqlDbType.Int32);
            insertRecipeINGR.Parameters.Add("@UnitName", MySqlDbType.String);
            insertRecipeINGR.Parameters.Add("@Ingredient", MySqlDbType.String);
            selectStorageAmount.Parameters.Add("@Ingredient", MySqlDbType.String);
            buyINGR.Parameters.Add("@Ingredient", MySqlDbType.String);
          try
            {
                StringBuilder str = new StringBuilder();
                //check that datagrid values are not null and delete one row since its always empty
                for (int i = 0; i <= GridIngredients.Count - 1 && GridIngredients[i] != null; i++ )
                {
                    //give value to parameters by getting every value inside datagrid in order
                   testINGR.Parameters["@Ingredient"].Value = GridIngredients[i].Ingredient.ToString();
                    insertINGR.Parameters["@Ingredient"].Value = GridIngredients[i].Ingredient.ToString();
                    insertRecipeINGR.Parameters["@Ingredient"].Value = GridIngredients[i].Ingredient.ToString();
                    insertRecipeINGR.Parameters["@Amount"].Value = Convert.ToInt32(GridIngredients[i].Amount);
                    insertRecipeINGR.Parameters["@UnitName"].Value = GridIngredients[i].UnitName.ToString();
                    selectStorageAmount.Parameters["@Ingredient"].Value = GridIngredients[i].Ingredient.ToString();

                    int storageAmount = selectStorageAmount.ExecuteNonQuery();
                    int neededAmount = GridIngredients[i].Amount;

                    if (neededAmount > storageAmount)
                    {
                        str.Append(GridIngredients[i].Ingredient.ToString() + ", ");
                    }
                    if (testINGR.ExecuteNonQuery() == 0)
                    {
                        insertINGR.ExecuteNonQuery();
                    }
                    
                    insertRecipeINGR.ExecuteNonQuery();
                }

                str.ToString().TrimEnd(',');
                buyINGR.Parameters["@Ingredient"].Value = str;
                buyINGR.ExecuteNonQuery();
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