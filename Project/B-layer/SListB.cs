using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
   public class SListB
    {

        //get shoppinglist
        public DataTable GetSList()
        {
            try
            {
                SListD objS = new SListD();
                return objS.Read();
            }
            catch
            {
                throw;
            }
        }
    }
}
