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
            EmployeeWageMonth employeeWageMonth = new EmployeeWageMonth();
            employeeWageMonth.EmpWageForMonth();

        }
    }
}