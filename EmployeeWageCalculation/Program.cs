using System;

namespace EmployeeWageCalculation
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Employee Wage Calculation Project !");
            EmpBuilderArray empWageBuilder = new EmpBuilderArray();
            empWageBuilder.addComapnyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addComapnyEmpWage("Relience", 10, 4, 20);
            empWageBuilder.computeEmpWage();
        }

    }

}