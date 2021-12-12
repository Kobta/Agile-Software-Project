using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class AddRecipeB
    {
        //textboxes
        public int AddRecipes(string name, string ctg, int aop, string inst)
        {
            try
            {
                AddRecipeD objS = new AddRecipeD();
                //onnistui
                return objS.Insert(name, ctg, aop, inst);

            }
            catch
            {
                throw;
            }
        }
        //datagrid
        public int AddRecipes(ObservableCollection<IngredientsListItem> GridIngredients)
        {
            try
            {
                AddRecipeD objS = new AddRecipeD();

                //onnistui
                return objS.Insert(GridIngredients);
            }
            catch
            {
                throw;
            }
        }
    }
}
