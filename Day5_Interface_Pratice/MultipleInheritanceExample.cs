using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training.Day5_Interface_Pratice
{
    interface IVegEatter
    {
        void EatVeg();
    }
    interface INonVegEatter
    {
        void EatNonVeg();
    }
    interface ITaste
    {
        void taste();
    }
    public class MultipleInheritanceExample
    {
        public class VegEatter:IVegEatter
        {
                       public void EatVeg()
            {
                Console.WriteLine("Eating Vegetables");
            }

        }
        public class NonVegEatter:INonVegEatter
        {
            public void EatNonVeg()
            {
                Console.WriteLine("Eating Non-Vegetables");
            }
        }
        public class Visitor : IVegEatter,INonVegEatter
        {
            public void EatNonVeg()
            {
                Console.WriteLine("This is NonVeg Eatter!");
            }

            public void EatVeg()
            {
                Console.WriteLine("This is Veg Eatter!");
            }

            public void Visit()
            {
                Console.WriteLine("Visiting the Restaurant");
            }
        }
    }
}
