using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    internal class EmpPresentAbsent
    {
        public void EmpPresentOrAbsent()
        {
            Console.WriteLine("UC1-Employee present or absent");

            Random randomval = new Random();

            int empCheck = randomval.Next(2); // 0 for absent 1 for present.

            Console.WriteLine("empCheck is= " + empCheck);
            if (empCheck == 1)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
