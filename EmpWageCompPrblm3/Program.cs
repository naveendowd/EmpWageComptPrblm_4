using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCompPrblm3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Welcome to Emp Wage Comp Prblm using Oops");

                EmpWage_UC1.EmployeeCheck();
                EmpWage_UC2.EmployeeWage();
                EmpWage_UC3.PartTimeEmployee();
                EmpWage_UC4.EmployeeWageSwitchCase();
                EmpWage_UC5.WagesforMonth();
                EmpWage_UC6.WageCondition();

            }
        }
    }
}