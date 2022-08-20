using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{

    internal interface DataInterFace
    {
        public ComputeWage GetData();

    }


    internal class AddNewCompany : DataInterFace
    {
        int CompanyIndex = 0; 
        string CompanyName;
        int WagePerHour;
        int NoOfWorkingDays;
        int TotalWorkingHrs;
        int TotalWage;
        static ComputeWage[] ComapanyArray = new ComputeWage[3]; 
        static int index = 0;
        List<ComputeWage> CompanyList = new List<ComputeWage>(); 

        public ComputeWage GetData()
        {
            Console.WriteLine("Enter Company name");
            this.CompanyName = Console.ReadLine();
            Console.WriteLine("Enter Wage per hour");
            this.WagePerHour = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number of working days");
            this.NoOfWorkingDays = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter total Number of working hours");
            this.TotalWorkingHrs = int.Parse(Console.ReadLine());
            ComputeWage computeWage = new ComputeWage(CompanyName, WagePerHour, NoOfWorkingDays, TotalWorkingHrs);
            this.TotalWage = computeWage.totalWage;
            return computeWage;

        }
        public void AddCompanyByArray() //UC10
        {
            ComputeWage computeWage = GetData();
            ComapanyArray[index] = computeWage;
            index++;

        }
        public void DisplayByArray() //UC10
        {
            for (int i = 0; i < ComapanyArray.Length; i++)
            {
                Console.WriteLine("Wage for company {0} is {1}", ComapanyArray[i].CompanyName, ComapanyArray[i].totalWage);
            }
        }

        public void AddCompanyBylist()   
        {
            ComputeWage computeWage = GetData();
            CompanyList.Add(computeWage);
            CompanyIndex++;
        }

        public void DisplayByList()  
        {
            foreach (var computeWage in CompanyList)
            {
                Console.WriteLine("Total wage for company {0} is {1}", computeWage.CompanyName, computeWage.totalWage);
            }
        }
        public void DisplayDailyByList()  
        {
            foreach (var computeWage in CompanyList)
            {
                Console.WriteLine("Total wage for company {0} is {1} ", computeWage.CompanyName, computeWage.totalWage);
                Console.Write("And dailyWage is: ");
                foreach (var dailywage in computeWage.DailyWage)
                {
                    Console.Write(dailywage + " ");
                }
                Console.WriteLine();

            }
        }
    }
}
