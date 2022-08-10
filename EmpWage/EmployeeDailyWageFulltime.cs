using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    internal class EmployeeDailyWageFulltime
    {
        int WagePerHr = 20;
        int isFullTime = 8;
        public void EmpWageFullTime()
        {
            Console.WriteLine("UC2-Employee daily wage absent, fulltime");

            Random randomval = new Random();

            int empCheck = randomval.Next(2); // 0 for absent 1 for present.

            Console.WriteLine("empCheck is= " + empCheck);


            if (empCheck == 1)
            {
                int dailyWage = WagePerHr * isFullTime;
                Console.WriteLine("Employee is present full time and daily wage is= " + dailyWage);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
