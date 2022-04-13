using System;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Creater creater = new Creater();
            Sell productComputer = creater.FactoryMethod(Creater.Sales.Computer);
            Sell productPhone = creater.FactoryMethod(Creater.Sales.Phone);
           
            productComputer.Product();
            productPhone.Product();

        }
    }
}
