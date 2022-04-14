using System;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Creator creator = new Creator();
            Sell productComputer = creator.FactoryMethod(Creator.Sales.Computer);
            Sell productPhone = creator.FactoryMethod(Creator.Sales.Phone);
           
            productComputer.Product();
            productPhone.Product();

        }
    }
}
