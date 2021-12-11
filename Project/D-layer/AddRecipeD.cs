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
        public string ConSt = "server=localhost;user id=root;database=applicationproject;sslmode=None";
        MySqlConnection connection = new MySqlConnection();

        //Tämä lisää textboxien sisällön tietokantaan
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
        //tämä lisää datagridin sisällön tietokantaan
        public int Insert(ObservableCollection<IngredientsListItem> GridIngredients)
        {
            connection.ConnectionString = ConSt;
            if (ConnectionState.Closed == connection.State)
                connection.Open();

            //tällee parametreilla tää kai pitäski tehä et ei voi injectaa : D
            MySqlCommand cmd = new MySqlCommand("insert into recipe_ingr (amount, unitType) values  (@Amount, @UnitName)", connection);
            //parametri pitää addaa ennenkuin siihen lisätään value
            cmd.Parameters.Add("@Ingredient", MySqlDbType.String);
            cmd.Parameters.Add("@Amount", MySqlDbType.Int32);
            cmd.Parameters.Add("@UnitName", MySqlDbType.String);
            try
            {
                //Tää katsoo että se gridin sisältö ei oo null ja sit poistaa yhden rivin sillä siellä aina on ainakin 1 rivi tyhjänä lopussa.
                for (int i = 0; i <= GridIngredients.Count - 1 && GridIngredients[i] != null; i++ )
                {
                    cmd.Parameters["@Ingredient"].Value = GridIngredients[i].Ingredient.ToString();
                    cmd.Parameters["@Amount"].Value = Convert.ToInt32(GridIngredients[i].Amount);
                    cmd.Parameters["@UnitName"].Value = GridIngredients[i].UnitName.ToString();
                    cmd.ExecuteNonQuery();
                }
                //asiat toimi
                return 1;
            }
            catch
            {
                throw;
            }
        }
    }
}
