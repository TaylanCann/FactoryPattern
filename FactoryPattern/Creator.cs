using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
     class Creator
    {
        public Sell FactoryMethod(Sales salesType)
        {
            Sell sell = null;

            switch (salesType)
            {
                case Sales.Phone:
                    sell = new Phone();
                    break;
                case Sales.Computer:
                    sell = new Computer();
                    break;
                
            }

            return sell;
        }
       public enum Sales
        { 
            Computer,
            Phone
        }
    }
}
