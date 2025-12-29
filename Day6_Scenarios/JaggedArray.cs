using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training.Day6_Scenarios
{

    class JaggedArray
    {
        static void Main()
        {
            int[][] data = new int[5][];
            data[0] = new int[] { 1, 2, 3 };
            data[1] = new int[] { 10, 20 };
            data[2] = new int[] { 7, 8, 9, 10 };
            data[3] = new int[] { 5, 9, 7, 3 };
            data[4] = new int[] { 1, 2 };

            for (int i = 0; i < data.Length; i++)
            {
                Console.Write("Row " + i + ": ");
                foreach (var v in data[i]) Console.Write(v + " ");
                Console.WriteLine();
            }
        }
    }
}
