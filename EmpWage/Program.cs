namespace EmpWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");

            EmpPresentAbsent uc1 = new EmpPresentAbsent();
            uc1.EmpPresentOrAbsent();

        }
    }
}