using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCompPrblm3
{
    internal class EmpWage_UC5
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int Number_Of_Days = 20;
        public static void WagesforMonth()
        {

            int Emp_Hrs = 0;
            int Emp_Wage = 0;

            Random random = new Random();

            int EmpCheck = random.Next(3);

            if (EmpCheck == IS_FULL_TIME)
            {
                Emp_Hrs = 8;
                Console.WriteLine("Employee is Present");

            }
            else if (EmpCheck == IS_PART_TIME)
            {
                Emp_Hrs = 4;
                Console.WriteLine("Employee is Present for Part Time");
            }
            else
            {
                Emp_Hrs = 0;
                Console.WriteLine("Employee is Absent");
            }
            Emp_Wage = Emp_Hrs * EMP_RATE_PER_HOUR * Number_Of_Days;

            Console.WriteLine("Employee Monthly wage is : " + Emp_Wage + " Rupees");
        }
    }
}