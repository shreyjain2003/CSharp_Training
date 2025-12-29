using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training.ConstructorEx
{
    public class Constructors
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Requirement { get; set; }
        public string LogHistory;
        public Constructors()
        {
            LogHistory += $"Object created at {DateTime.Now.ToString()} {Environment.NewLine}";
        }
        public Constructors(int id) : this()
        {
            this.Id = id;
            LogHistory += $"Id created at {DateTime.Now.ToString()}{Environment.NewLine}";
            if (id < 1)
            {
                throw new ArgumentException("Give a valid ID!");
            }
        }
        public Constructors(int id, string name):this(id) 
        {
            //this.Id = id;

            if (name.ToLower().Contains("idiot"))
                throw new ArgumentException("You idiot,dont say like this!");
            this.Name = name;
            LogHistory += $"Name is created at {DateTime.Now.ToString()}{Environment.NewLine}";
        }
        public Constructors(int id, string name, string requirement): this(id,name)
        {
            //this.Id = id;
            if (requirement.ToLower().Contains("no"))
                throw new ArgumentException("Stupid, tell me valid requirement!");
            //this.Name = name;
            this.Requirement = requirement;
            LogHistory += $"Requirement is created at {DateTime.Now.ToString()}{Environment.NewLine}";
        }

    }
}
