using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    internal class EmpWageSwitchCase
    {
        int WagePerHr = 20;
        int isFullTime = 8;
        int isPartTime = 4;
        int dailyWage = 0;
        public void EmployeeWageSwitchCase()
        {
            Console.WriteLine("UC4-Employee daily wage  fulltime parttime by switch case");

            Random randomval = new Random();

            int empCheck = randomval.Next(3);
            Console.WriteLine("empCheck is= " + empCheck);


            switch (empCheck)
            {
                case 1:
                    dailyWage = WagePerHr * isFullTime;
                    Console.WriteLine("Employee is present full time and daily wage is= " + dailyWage);

                    break;

                case 2:
                    dailyWage = WagePerHr * isPartTime;

                    Console.WriteLine("Employee is present Part time and daily wage is= " + dailyWage);
                    break;

                default:

                    Console.WriteLine("Employee is Absent");
                    break;
            }
        }
    }
}
