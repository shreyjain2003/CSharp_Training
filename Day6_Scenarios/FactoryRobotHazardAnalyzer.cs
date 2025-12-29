using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training.Day6_Scenarios
{
        // ---------------------------------------------------
        // Custom Exception Class
        // ---------------------------------------------------
        public class RobotSafetyException : Exception
        {
            public RobotSafetyException(string message) : base(message)
            {
            }
        }

        // ---------------------------------------------------
        // Auditor Class
        // ---------------------------------------------------
        public class RobotHazardAuditor
        {
            // Method to calculate hazard risk
            public double CalculateHazardRisk(double armPrecision, int workerDensity, string machineryState)
            {
                // Validate arm precision
                if (armPrecision < 0.0 || armPrecision > 1.0)
                {
                    throw new RobotSafetyException("Error: Arm precision must be 0.0-1.0");
                }

                // Validate worker density
                if (workerDensity < 1 || workerDensity > 20)
                {
                    throw new RobotSafetyException("Error: Worker density must be 1-20");
                }

                // Determine machine risk factor
                double machineRiskFactor;

                if (machineryState == "Worn")
                {
                    machineRiskFactor = 1.3;
                }
                else if (machineryState == "Faulty")
                {
                    machineRiskFactor = 2.0;
                }
                else if (machineryState == "Critical")
                {
                    machineRiskFactor = 3.0;
                }
                else
                {
                    throw new RobotSafetyException("Error: Unsupported machinery state");
                }

                // Hazard risk calculation
                double hazardRisk =
                    ((1.0 - armPrecision) * 15.0) +
                    (workerDensity * machineRiskFactor);

                return hazardRisk;
            }
        }

        // ---------------------------------------------------
        // Program Class
        // ---------------------------------------------------
        class FactoryRobotHazardAnalyzer
    {
            static void Main(string[] args)
            {
                try
                {
                    RobotHazardAuditor auditor = new RobotHazardAuditor();

                    Console.WriteLine("Enter Arm Precision (0.0 - 1.0):");
                    double armPrecision = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter Worker Density (1 - 20):");
                    int workerDensity = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Machinery State (Worn/Faulty/Critical):");
                    string machineryState = Console.ReadLine();

                    double risk = auditor.CalculateHazardRisk(
                        armPrecision,
                        workerDensity,
                        machineryState
                    );

                    Console.WriteLine("Robot Hazard Risk Score: " + risk);
                }
                catch (RobotSafetyException ex)
                {
                    // Display exception message
                    Console.WriteLine(ex.Message);
                }

                Console.ReadLine();
            }
        }
    

}
