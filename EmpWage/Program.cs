namespace EmpWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            //UC1

            //EmpPresentAbsent uc1 = new EmpPresentAbsent();
            //uc1.EmpPresentOrAbsent();

            ////UC2

            //EmployeeDailyWageFulltime employeeDailyWageFulltime = new EmployeeDailyWageFulltime();
            //employeeDailyWageFulltime.EmpWageFullTime();

            //UC3

            //EmpWageFullPart empWageFullPart = new EmpWageFullPart();
            //empWageFullPart.EmpWageFullPartTime();

            ////UC4
            //EmpWageSwitchCase empWageSwitchCase = new EmpWageSwitchCase();
            //empWageSwitchCase.EmployeeWageSwitchCase();

            //UC5
            //EmployeeWageMonth employeeWageMonth = new EmployeeWageMonth();
            //employeeWageMonth.EmpWageForMonth();

            //UC6
            //EmployeeWageDayHr employeeWageDayHr = new EmployeeWageDayHr();
            //employeeWageDayHr.EmpWageForMonthHr();

            //// UC7

            //ClassMembersEmployeeWage classMembersEmployeeWage = new ClassMembersEmployeeWage();
            //classMembersEmployeeWage.EmpWageForMonthHr();

            //UC8
            //MultipleCompanyWage multipleCompanyWage = new MultipleCompanyWage();
            //multipleCompanyWage.EmpWageForMonthHr("BridgeLabz", 30, 25, 100);
            //multipleCompanyWage.EmpWageForMonthHr("Tata", 25, 25, 100);

            //Uc9

            //ComputeWage Tata = new ComputeWage("Tata", 20, 20, 100);
            //Tata.DisplaySalary();

            //  UC10
            // AddNewCompany company = new AddNewCompany();

            //   UC10
            //for (int i = 0; i < 3; i++)
            //{

            //    company.AddCompanyByArray();

            //}
            //company.DisplayByArray();

            ////Uc11
            //AddNewCompany company = new AddNewCompany();
            //for (int i = 0; i < 3; i++)
            //{

            //    company.AddCompanyByArray();

            //}
            //company.DisplayByArray();

            //Uc12
            // AddNewCompany company = new AddNewCompany();
            // Console.WriteLine("Enter y to add company");
            // string input = Console.ReadLine();
            // while (input == "y")
            // {
            //     company.AddCompanyBylist();
            //     Console.WriteLine("Company Data Stored again enter y to add company");
            //     input = Console.ReadLine();

            // }
            //company.DisplayByList(); 

            //Uc13

            AddNewCompany company = new AddNewCompany();
            Console.WriteLine("Enter y to add company");
            string input = Console.ReadLine();
            while (input == "y")
            {
                company.AddCompanyBylist();
                Console.WriteLine("Company Data Stored again enter y to add company");
                input = Console.ReadLine();

            }
            company.DisplayByList();
            company.DisplayDailyByList();
        }
    }
}