using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training.Oops.add
{
    public class AdditionConstructor
    {
        public int Num1 { get; set; }   //Use 'set' property only try it once to see what happens!
        public int Num2 { get; set; }
        public int Sum { get; }
        public AdditionConstructor(int num1,int num2) 
        {
            this.Num1 = Num1;
            this.Num2 = Num2;
            Sum = Num1 + Num2;  
            //Only in Constructors 'get' properties can set the values.
            
        }
    }
}
