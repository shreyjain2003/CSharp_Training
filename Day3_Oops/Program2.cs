using Capgemini_Training;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training
{
    class Program2
    {
        static void Main(string[] args)
        {
            // Creating Employees
            Employee e1 = new Employee(101, "Shreyansh");
            Employee e2 = new Employee(102, "Amit");
            Employee e3 = new Employee(103, "Rohit");

            // Creating Competitions with Scores
            Competition c1 = new Competition("Coding Contest", 85, e1);
            Competition c2 = new Competition("Hackathon", 92, e2);
            Competition c3 = new Competition("Debug Challenge", 88, e3);

            // Assume first employee has highest score initially
            Competition winner = c1;

            if (c2.Score > winner.Score)
                winner = c2;

            if (c3.Score > winner.Score)
                winner = c3;

            // Output
            Console.WriteLine("🏆 Competition Winner 🏆");
            Console.WriteLine("Employee ID   : " + winner.Emp.EmpId);
            Console.WriteLine("Employee Name : " + winner.Emp.EmpName);
            Console.WriteLine("Competition   : " + winner.CompetitionName);
            Console.WriteLine("Score         : " + winner.Score);

            Console.ReadLine();
        }
    }
}