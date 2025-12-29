using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training.Day6_Scenarios
{
        // ---------------------------------------------------
        // Abstract Base Class
        // ---------------------------------------------------
        public abstract class EmployeeRecord
        {
            public string EmployeeName { get; set; }
            public double[] WeeklyHours { get; set; }

            public abstract double GetMonthlyPay();
        }

        // ---------------------------------------------------
        // Full Time Employee
        // ---------------------------------------------------
        public class FullTimeEmployee : EmployeeRecord
        {
            public double HourlyRate { get; set; }
            public double MonthlyBonus { get; set; }

            public override double GetMonthlyPay()
            {
                return WeeklyHours.Sum() * HourlyRate + MonthlyBonus;
            }
        }

        // ---------------------------------------------------
        // Contract Employee
        // ---------------------------------------------------
        public class ContractEmployee : EmployeeRecord
        {
            public double HourlyRate { get; set; }

            public override double GetMonthlyPay()
            {
                return WeeklyHours.Sum() * HourlyRate;
            }
        }

        // ---------------------------------------------------
        // Program Class
        // ---------------------------------------------------
        public class PayRollPro
    {
            // Static Collection
            public static List<EmployeeRecord> PayrollBoard = new List<EmployeeRecord>();

            // Register Employee
            public void RegisterEmployee(EmployeeRecord record)
            {
                PayrollBoard.Add(record);
            }

            // Overtime Week Count
            public Dictionary<string, int> GetOvertimeWeekCounts(List<EmployeeRecord> records, double hoursThreshold)
            {
                Dictionary<string, int> result = new Dictionary<string, int>();

                foreach (EmployeeRecord emp in records)
                {
                    int count = emp.WeeklyHours.Count(h => h >= hoursThreshold);

                    if (count > 0)
                    {
                        result.Add(emp.EmployeeName, count);
                    }
                }

                return result;
            }

            // Average Monthly Pay
            public double CalculateAverageMonthlyPay()
            {
                if (PayrollBoard.Count == 0)
                    return 0;

                double totalPay = 0;

                foreach (EmployeeRecord emp in PayrollBoard)
                {
                    totalPay += emp.GetMonthlyPay(); // Polymorphism
                }

                return totalPay / PayrollBoard.Count;
            }

            // ---------------------------------------------------
            // Main Method
            // ---------------------------------------------------
            static void Main(string[] args)
            {
                PayRollPro program = new PayRollPro();

                while (true)
                {
                    Console.WriteLine("1. Register Employee");
                    Console.WriteLine("2. Show Overtime Summary");
                    Console.WriteLine("3. Calculate Average Monthly Pay");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine();
                    Console.WriteLine("Enter your choice:");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 1)
                    {
                        Console.WriteLine("Select Employee Type (1-Full Time, 2-Contract):");
                        int type = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Employee Name:");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter Hourly Rate:");
                        double rate = Convert.ToDouble(Console.ReadLine());

                        double[] hours = new double[4];
                        Console.WriteLine("Enter weekly hours (Week 1 to 4):");
                        for (int i = 0; i < 4; i++)
                        {
                            hours[i] = Convert.ToDouble(Console.ReadLine());
                        }

                        if (type == 1)
                        {
                            Console.WriteLine("Enter Monthly Bonus:");
                            double bonus = Convert.ToDouble(Console.ReadLine());

                            FullTimeEmployee ft = new FullTimeEmployee
                            {
                                EmployeeName = name,
                                HourlyRate = rate,
                                MonthlyBonus = bonus,
                                WeeklyHours = hours
                            };

                            program.RegisterEmployee(ft);
                        }
                        else
                        {
                            ContractEmployee ct = new ContractEmployee
                            {
                                EmployeeName = name,
                                HourlyRate = rate,
                                WeeklyHours = hours
                            };

                            program.RegisterEmployee(ct);
                        }

                        Console.WriteLine("Employee registered successfully");
                        Console.WriteLine();
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("Enter hours threshold:");
                        double threshold = Convert.ToDouble(Console.ReadLine());

                        Dictionary<string, int> overtime =
                            program.GetOvertimeWeekCounts(PayrollBoard, threshold);

                        if (overtime.Count == 0)
                        {
                            Console.WriteLine("No overtime recorded this month");
                        }
                        else
                        {
                            foreach (var item in overtime)
                            {
                                Console.WriteLine(item.Key + " - " + item.Value);
                            }
                        }

                        Console.WriteLine();
                    }
                    else if (choice == 3)
                    {
                        double avg = program.CalculateAverageMonthlyPay();
                        Console.WriteLine("Overall average monthly pay: " + avg);
                        Console.WriteLine();
                    }
                    else if (choice == 4)
                    {
                        Console.WriteLine("Logging off — Payroll processed successfully!");
                        break;
                    }
                }
            }
        }

}
