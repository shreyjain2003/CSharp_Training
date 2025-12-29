using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training.Oops
{
    public class Associate
    {
        private int id;
        private string Name { set; get; }
        private int Rank { set; get; }
        public string Errormsg;
        
        public int Id1
        {
            set
            {
                if(value<=0)
                {
                    throw new ArgumentOutOfRangeException("Enter a positive number!");
                }
                else
                {
                    id= value;
                }
            }
        }
        public string Name1
        {
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Don't enter null value or invalid format.");
                }

            }
        }
        public int Rank1
        {
            set
            {
                if(value <0)
                {
                    throw new ArgumentOutOfRangeException("Enter valid Rank!");
                }
                else
                {
                    Rank=value;
                }
            }
        }
    }
    public class ErrorHandling
    {
        public static void main(string[] args)
        {
            try
            {
                Associate associate = new Associate();
                associate.Rank1=101;
                associate.Name1=string.Empty;
                associate.Id1=1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
        }
        
    }
}
