using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training
{
    /// <summary>
    /// This Program checks the eligibility of a student for admission based on their marks in Mathematics, Physics, and Chemistry.
    /// </summary>
    public class Admission_Eligibility
    {
        /// <summary>
        /// Serves as the entry point for the application, evaluating a student's eligibility for admission based on
        /// input marks in Mathematics, Physics, and Chemistry.
        /// </summary>
        /// <remarks>The method prompts the user to enter marks for Mathematics, Physics, and Chemistry
        /// via the console. Eligibility is determined according to specified criteria and the result is displayed to
        /// the user.</remarks>
        /// <param name="args">An array of command-line arguments. This parameter is not used.</param>
        static void Main(string[] args)   
        {
            Console.WriteLine("Enter marks in Mathematics, Physics and Chemistry respectively:");
            int Math=int.Parse(Console.ReadLine());
            int Phys=int.Parse(Console.ReadLine());
            int Chem=int.Parse(Console.ReadLine());
            int Total= Math + Phys + Chem;
            bool isEligible = false;
            if(Math>=65 && Phys>=55 && Chem>=50 && (Total>=180 || (Math + Phys >= 140))){
                isEligible = true;
            }

            if (isEligible = true)
            {
                Console.WriteLine("You are Eligible for Admission!");
                
            }
            else
            {
                Console.WriteLine("You are not Eligible for Admission!");
            }
        }
    }
}
