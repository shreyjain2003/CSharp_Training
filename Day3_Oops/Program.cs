using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Capgemini_Training
{
        class Program
        {
            static void Main(string[] args)
            {
                // Creating object using constructor
                Student1 s1 = new Student1(101, "Shreyansh");

                s1.Display();
                Console.ReadLine();
            }
        }

}