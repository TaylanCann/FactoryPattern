using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public abstract class Sell
    {
        public abstract void Product();
    }

    public class Computer : Sell
    {
        public override void Product()
        {
            Console.WriteLine("Computer sold.");
        }
    }

    public class Phone : Sell
    {
        public override void Product()
        {
            Console.WriteLine("Phone sold.");
        }
    }
}
