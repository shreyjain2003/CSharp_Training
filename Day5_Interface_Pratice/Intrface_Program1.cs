using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training.Day5_Interface_Pratice
{
    public interface IPrint
    {
        void Print();
    }
    class Document : IPrint
    {
        public void Print()
        {
            Console.WriteLine("Printing The Document");
        }
    }
    public class Intrface_Program1
    {
        public static void Main(string[] args)
        {
            IPrint printer = new Document();
            printer.Print();
            Console.ReadLine();
        }        
    }
}
