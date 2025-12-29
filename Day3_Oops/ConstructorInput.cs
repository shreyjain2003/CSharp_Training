using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capgemini_Training.ConstructorEx;

namespace Capgemini_Training
{
    public class ConstructorInput
    {
        public static void Main(string[] args)
        {
            Constructors dd=new Constructors();
            try
            {
                Constructors constructor = new Constructors(10, "Ravi", "Computer");
                //Constructors constructor2 = new Constructors(10, "Ravi");
                //Constructors constructor3 = new Constructors(1);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
