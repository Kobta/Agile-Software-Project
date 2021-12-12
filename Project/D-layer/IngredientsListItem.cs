using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project
{
    //this containes every ingredient that user gives
    public class IngredientsListItem
    {
        public string Ingredient { get; set; }
        public int Amount { get; set; }
        public string UnitName { get; set; }


        //these are test ingredients
        public IngredientsListItem()
        {
            Ingredient = "carrot";
            Amount = 400;
            UnitName = "Grams";

        }

    }
}
