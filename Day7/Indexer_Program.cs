using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training.Day7_Indexer
{
    class MyData
    {
        private string[] values = new string[3];

        public string this[int index]
        {
            get
            {
                return values[index];
            }
            set
            {
                values[index] = value;
            }
        }
    }
    class Indexer_Program
    {
        static void Main(string[] args)
        {
            MyData data = new MyData();
            data[0] = "Capgemini";
            data[1] = "Training";
            data[2] = "2024";

            Console.WriteLine("Indexer 1st value(index 0): " + data[0]);
            Console.WriteLine("Indexer 2nd value(index 1): " + data[1]);
            Console.WriteLine("Indexer 3rd value(index 2): " + data[2]);

        }
    }

}
