using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class MealsB
    {
        public DataTable GetMeal()
        {
            try
            {
                MealsD objS = new MealsD();
                return objS.Read();
            }
            catch
            {
                throw;
            }
        }
    }
}
