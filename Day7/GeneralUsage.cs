using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training.Day7
{
    /// <summary>
    /// Using static constructor and static members.
    /// </summary>
    public static class GeneralUsage
    {
        public static int Rno;
        /// <summary>
        /// Initializes static members of the GeneralUsage class.
        /// </summary>

        static GeneralUsage()
        {
            Rno = 1;
        }
        /// <summary>
        /// Gets the current value of the Rno field.
        /// </summary>
        /// <returns>The value of Rno as an integer.</returns>
        public static int GetRno()
        {
            return Rno;
        }
    }
}
