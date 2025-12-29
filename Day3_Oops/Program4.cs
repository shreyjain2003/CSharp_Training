using Capgemini_Training;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training
{
    public class Program4
    {
        public static void Main(string[] args)
        {
            #region Ex1
            //Student student = new Student();
            //student.Id = 1;
            //student.Name = "Arun";

            //Student student1 = new Student() 
            //{ 
            //    Id = 10, 
            //    Name = "Babu" 
            //};

            //string studentDetails = student1.GetDetails();
            //Console.WriteLine(studentDetails);
            #endregion

            Program4 program = new Program4();
            FamilyDefination person = new FamilyDefination() { Id = 1, Age = 20, Name = "Arul" };
            program.GetDetails(person);
            Man man = new Man() { Id = 10, Name = "Kumar", Age = 24, Playing = "Football" };

            Woman woman = new Woman() { Id = 10, Name = "Kumari", Age = 24, PlayManage = "Rugby and Home" };

            FamilyDefination personw = woman;

            FamilyDefination childObject = new Child() { Age = 1, Id = 100, Name = "Anki", WatchCartoon = "Chota Beem" };
            program.GetDetails(person);
            program.GetDetails(childObject);
            Console.WriteLine(program.GetDetails(childObject));
            Console.WriteLine(program.GetBoth(man));
            Console.WriteLine(program.GetBoth(woman));
            Console.WriteLine(program.GetBoth(childObject));
        }
        public string GetBoth(FamilyDefination person)
        {
            if (person is Man)
            {
                Man man = (Man)person;
                return $"Name : {man.Name}, Age : {man.Age},Playing : {man.Playing}";
            }
            else if (person is Woman)
            {
                Woman woman = (Woman)person;
                return $"Name: {woman.Name},Age: {woman.Age},Play and Manage : {woman.PlayManage}";
            }
            else
            {
                Child child = (Child)person;
                return $"Name: {child.Name},Age: {child.Age},Cartoon: {child.WatchCartoon}";

            }
        }

                public string GetManDetails(Man input)
                {
                    return $" Id = {input.Id}  Name = {input.Name}";
                }

        public string GetWomanDetails(Woman input)
        {
            return $" Id = {input.Id}  Name = {input.Name}";
        }

        public string GetDetails(FamilyDefination person)
        {
            return $" Id = {person.Id}  Name = {person.Name}";
        }
    }
}


