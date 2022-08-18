using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    internal class MultipleCompanyWage
    {

        const int isFullTime = 1;
        const int isPartTime = 2;

        public void EmpWageForMonthHr(string CompanyName, int wagePerHour, int MaxWorkDays, int MaxWorkHrs)
        {
            Console.WriteLine();

            Console.WriteLine("Calculate Wages till a condition of total working hours or days is reached for a month - Assume 100 hours");
            Random rand = new Random();
            // it will give values from 0 till 3 but not 3 so possible output is 1,2

            int empHrs=0;
            int dailyWage;
            int totalWage = 0;
            int totalNoOfHrs = 0;
            int totalWorkingDays = 0;
            while (totalWorkingDays < MaxWorkDays && totalNoOfHrs <= MaxWorkHrs)
            {
                int empCheck = rand.Next(0, 3);
                switch (empCheck)
                {
                    case isFullTime:
                        empHrs = 8;
                        break;

                    case isPartTime:
                        empHrs = 4;
                        break;

                    default:
                        empHrs = 0;
                        break;

                }

                dailyWage = wagePerHour * empHrs;
                totalWage = totalWage + dailyWage;
                totalNoOfHrs = totalNoOfHrs + empHrs;
                totalWorkingDays++;
            }

            Console.WriteLine("Total No of hours are {0} and working days are {1}", totalNoOfHrs-empHrs, totalWorkingDays);
            Console.WriteLine("Total Wage Of {0} Company employee is: {1} ", CompanyName, totalWage);
        }
    }
}
