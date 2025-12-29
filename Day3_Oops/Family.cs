using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training.Oops
{
    public class Father
    {
        public virtual string InterestOn()  //Virtual used to tell that this func can be override.
        {
            return "I like to play Cricket!";
        }
    }
    public class Son : Father
    {
        public override string InterestOn()  //this shows that this func is overriding the parent func.
        {
            return "Mobile Game!";
        }
    }
}
