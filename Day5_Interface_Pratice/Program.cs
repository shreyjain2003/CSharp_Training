using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training.Day5_Interface_Pratice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MultipleInheritanceExample.Visitor visitor = new MultipleInheritanceExample.Visitor();
            visitor.Visit();
            //IVegEatter vergEatter = new Visitor;
            //string nvTaste = nonVegEater.GetTaste();

            //INonVegEater nonVegEater = new Visitor();
            //string nvTaste=nonVegEater.GetTaste();
        }
    }
}
