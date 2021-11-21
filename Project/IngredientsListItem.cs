using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project
{
    public class IngredientsListItem
    {
        public string Ingredient { get; set; }
        public double Amount { get; set; }
        public string UnitName { get; set; }



        public IngredientsListItem()
        {
            Ingredient = "carrot";
            Amount = 400;
            UnitName = "Grams";

        }

    }
}
