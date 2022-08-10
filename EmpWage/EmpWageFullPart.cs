using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    internal class EmpWageFullPart
    {
        int WagePerHr = 20;
        int isFullTime = 8;
        int isPartTime = 4;
        public void EmpWageFullPartTime()
        {

            Console.WriteLine("UC3-Employee daily wage fulltime,parttimee ");


            Random randomval = new Random();

            int empCheck = randomval.Next(3); // 0 for absent 1 for present.

            Console.WriteLine("empCheck is= " + empCheck);

            if (empCheck == 0)
            {
                Console.WriteLine("Employee is Absent");
            }
            else if (empCheck == 1)
            {
                int dailyWage = WagePerHr * isFullTime;
                Console.WriteLine("Employee is present full time and daily wage is= " + dailyWage);
            }
            else
            {
                int dailyWage = WagePerHr * isPartTime;
                Console.WriteLine("Employee is present Part time and daily wage is= " + dailyWage);
            }
        }
    }
}
