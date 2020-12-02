using System;

namespace EmployeeWageCalculation
{
    class Program
    {
       
        static void Main(string[] args)
        {

            Console.WriteLine("Welcom to Employee Wage Calculation Project !");
            EmpBuilderObject dMart = new EmpBuilderObject("DMart",20,2,10);
            EmpBuilderObject relience = new EmpBuilderObject("Relience", 10,4,20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            relience.computeEmpWage();
            Console.WriteLine(relience.toString());


        }
    }
    public class EmpBuilderObject {
        //Constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
    
        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public EmpBuilderObject(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void computeEmpWage()

        {
            //Variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
            {
                Random random = new Random();
                //Computation
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day# : " + totalWorkingDays + "Emp Hrs : " + empHrs);
            }
            totalEmpWage = totalEmpHrs * this.empRatePerHour;
            Console.WriteLine("Total Emp Wage for Company: " + company + " is " + totalEmpWage);
            
        }
        public string toString()
        {
                           

            return "Total Emp Wage for Company : " + this.company + "is :" + this.totalEmpWage;

        }


    }
}
