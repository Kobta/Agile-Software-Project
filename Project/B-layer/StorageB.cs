using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
   public class StorageB
    {
        //get everything in foodstuff
        public DataTable GetStorage()
        {
            try
            {
                StorageD objS = new StorageD();
                return objS.Read();
            }
            catch
            {
                throw;
            }
        }
        //search
        public DataTable GetStorage(string name)
        {
            try
            {
                StorageD objS = new StorageD();
                return objS.Read(name);
            }
            catch
            {
                throw;
            }
        }
    }
}
