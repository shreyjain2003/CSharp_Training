using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training.Day5_Scenarios
{
    public class Program_OverfowDatatypes
    {
        /// <summary>
        /// This Scenario is Round Robin as int max value is exceeded and goes to negative value.
        /// </summary>
        public int MultiMath(int n, out int sqrValue,out int halfValue,out int AddBy2)
        {
            sqrValue = 0;
            sqrValue = n * n;
            halfValue = n / 2;
            AddBy2 = n + 2;
            return n;
        }
        public static void Main()
        {
            int max = int.MaxValue;
            int overflowval = max + 1;
            Console.WriteLine(overflowval);
            int n = 10;
            int square,half, addby2;
            
        }

    }
}
