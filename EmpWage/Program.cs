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
            EmpWageFullPart empWageFullPart = new EmpWageFullPart();
            empWageFullPart.EmpWageFullPartTime();

        }
    }
}