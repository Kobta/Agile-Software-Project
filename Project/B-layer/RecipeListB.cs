using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
   public class RecipeListB
    {

        //get list of recipes
        public DataTable GetRecipeList()
        {
            try
            {
                RecipeD objS = new RecipeD();
                return objS.Read();
            }
            catch
            {
                throw;
            }
        }
        //get search result
        public DataTable GetRecipeList(string name)
        {
            try
            {
                RecipeD objS = new RecipeD();
                return objS.Read(name);
            }
            catch
            {
                throw;
            }
        }

        public DataTable ShowIngredients(int id)
        {
            try
            {
                RecipeD objS = new RecipeD();
                return objS.ShowIngredients(id);
            }
            catch
            {
                throw;
            }
        }

        //show instructions
        public string ShowInstructions(string value)
        {
            try
            {
                RecipeD objS = new RecipeD();
                return objS.Show(value);
            }
            catch
            {
                throw;
            }
        }

        //add recipe to meal
        public int AddToMeal(string value, string ddt, int id)
        {
            try
            {
                RecipeD objS = new RecipeD();
                return objS.Add(value, ddt, id);
            }
            catch
            {
                throw;
            }
        }
    }
}
