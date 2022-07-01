using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton.Models
{
    class DbContext
    {
        private static readonly object padlock = new object();
        private DbContext()
        {

        }

        private static DbContext context;

        public static DbContext GetContextInstance()
        {
            //Double Checked Locking -çift kontrol kilitleme modeli
           
            if (context == null)
            {
                lock (padlock)
                {
                    if (context == null)
                        context = new DbContext();
                }
            }
            return context;
        }
    }
}
