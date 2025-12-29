using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training.Oops
{
    public class CallField
    {
        public static void main(string[] args)
        {
            Employee employee = new Employee();
            employee.Id = 100;
            string result=employee.DisplayEmpDetails();
            Console.WriteLine(result);
        }
    }
}
