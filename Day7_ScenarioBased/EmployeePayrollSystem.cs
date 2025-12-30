using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training.Day7_ScenarioBased
{

        // 🔹 Base Class
        class Employee
        {
            public int EmployeeId { get; set; }
            public string Name { get; set; }

            // Virtual method (can be overridden)
            public virtual decimal CalculateSalary()
            {
                return 0;
            }
        }

        // 🔹 Derived Class: Full-Time Employee
        class FullTimeEmployee : Employee
        {
            public decimal MonthlySalary { get; set; }

            public override decimal CalculateSalary()
            {
                return MonthlySalary;
            }
        }

        // 🔹 Derived Class: Contract Employee
        class ContractEmployee : Employee
        {
            public decimal HourlyRate { get; set; }
            public int HoursWorked { get; set; }

            public override decimal CalculateSalary()
            {
                return HourlyRate * HoursWorked;
            }
        }

        // 🔹 Program Class
        class EmployeePayrollSystem
    {
        static void Main()
        {
            Employee emp1 = new FullTimeEmployee
            {
                EmployeeId = 101,
                Name = "Amit",
                MonthlySalary = 50000
            };

            Employee emp2 = new ContractEmployee
            {
                EmployeeId = 102,
                Name = "Ravi",
                HourlyRate = 500,
                HoursWorked = 80
            };

            Console.WriteLine($"{emp1.Name} Salary: {emp1.CalculateSalary()}");
            Console.WriteLine($"{emp2.Name} Salary: {emp2.CalculateSalary()}");
        }
        }
}
