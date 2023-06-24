﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Portal");

            EmpWageBuilder company = new EmpWageBuilder();
            company.AddCompanyDetails("TataSteel", 30, 20, 140);
            company.AddCompanyDetails("Sony", 40, 22, 160);
            company.AddCompanyDetails("ITC", 33, 26, 170);
            company.IterateOverCompanies();
        }
    }

    internal class EmpWageBuilder
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;

        private int indexOfCompany = 0;
        CompanyDetails[] companiesArray;// new CompanyDetails[5];

        public EmpWageBuilder()
        {
            companiesArray = new CompanyDetails[5];
        }

        public void AddCompanyDetails(string company, int empRatePerHour, int noOfWorkingDays, int maxHrsPerMonth)
        {
            CompanyDetails comp = new CompanyDetails(company, empRatePerHour, noOfWorkingDays, maxHrsPerMonth);
            companiesArray[indexOfCompany] = comp;
            indexOfCompany++;
        }

        public void IterateOverCompanies()
        {
            for (int i = 0; i < companiesArray.Length; i++)
            {
                if (companiesArray[i] != null)
                {
                    int totalWage = CalcWage(companiesArray[i]);
                    companiesArray[i].SetTotalEmpWage(totalWage);
                }
                else
                {
                    break;
                }
            }
        }


        public static int CalcWage(CompanyDetails obj)
        {
            int empHrs = 0;
            int totalWage = 0;
            int day = 1;
            int totalHrs = 0;
            //Console.WriteLine("Welcome to Employee Wage Computation Portal");
            Random random = new Random();
            while (day <= obj.noOfWorkingDays /*obj.noOfWorkigDays*/&& totalHrs < obj.maxHrsPerMonth/*obj.maxHrsPerMonth*/)
            {
                int randomInput = random.Next(0, 3);//0 or 1 or 2
                switch (randomInput)
                {
                    case FULL_TIME:
                        empHrs = 8;
                        //Console.WriteLine("Full time employee is present");

                        break;
                    case PART_TIME:
                        empHrs = 4;
                        //Console.WriteLine("Part time employee is present");

                        break;
                        //default: //absent
                        //Console.WriteLine("Employee is absent");
                        //break;
                }
                int empWage = /*obj.empRatePerHour */obj.empRatePerHour * empHrs;
                totalWage += empWage; //totalWage =totalWage+empWage;
                totalHrs += empHrs;
                //Console.WriteLine("Employee Wage on day{0} for working {1}hrs is {2}", day, empHrs, empWage);
                day++;
            }
            //Console.WriteLine(company + ": total Wage for {0} days or {1} Hrs (Employee is allowed to work until eiter of max working days or max working hours is reached first) is {2}", (day - 1), totalHrs, totalWage);
            Console.WriteLine("Compamy: {0}, Total Wage: {1}", /*obj.company*/obj.company, totalWage);
            return totalWage;
        }
    }
}