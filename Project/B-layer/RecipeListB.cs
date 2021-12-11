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

        public DataTable GetRecipeLists(string value)
        {
            try
            {
                RecipeD objS = new RecipeD();
                return objS.Read(value);
            }
            catch
            {
                throw;
            }
        }
    }
}
