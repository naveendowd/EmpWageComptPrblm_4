using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_EmployeeWageComputation
{
    internal class CompanyDetails
    {
        public string company;
        public int empRatePerHour, noOfWorkingDays, maxHrsPerMonth, totalWage;

        public CompanyDetails(string company, int empRatePerHour, int noOfWorkingDays, int maxHrsPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.noOfWorkingDays = noOfWorkingDays;
            this.maxHrsPerMonth = maxHrsPerMonth;
        }

        public void SetTotalEmpWage(int totalEmpWage)
        {
            totalWage = totalEmpWage;
        }
    }
}