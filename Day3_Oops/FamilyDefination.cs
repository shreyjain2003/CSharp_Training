using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training
{
    public class FamilyDefination
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class Man:FamilyDefination
    {
        public string Playing { get; set; }
    }
    public class Woman:FamilyDefination
    {
        public string PlayManage { get; set; }
    }
    public class Child : FamilyDefination
    {
        public string WatchCartoon { get; set; }
    }

}
