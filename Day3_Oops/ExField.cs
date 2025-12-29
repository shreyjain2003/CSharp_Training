using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training.Oops
{
    public class Employee
    {
        private int id;
        //Right click on id go to Quick actions.. option then encapsulation..(1st option).
        public int Id
        {
            set
            {
                if(value > 0)
                {
                    id = value;
                }
                else
                {
                    id = 0;
                    throw new InvalidOperationException("How Id can be less than Zero!");
                }
            } 
        }

        public string DisplayEmpDetails()
        {
            return $"Employee Id is {id}";
        }
    }
}
