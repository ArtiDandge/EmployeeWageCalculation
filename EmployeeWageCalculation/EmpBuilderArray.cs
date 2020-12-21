using System;
using System.Collections.Generic;

namespace EmployeeWageCalculation
{
<<<<<<< HEAD
    public class EmpBuilderArray : IComputeEmpWage
    {
        //Constants
=======
    public class EmpBuilderArray: IComputeEmpWage
    { 
>>>>>>> 898d7d1fb4536466984ff56d988dfeebfd378ea1
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private LinkedList<CompanyEmpWage> companyEmpWaeList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;

        public EmpBuilderArray()
        {
            this.companyEmpWaeList = new LinkedList<CompanyEmpWage>();
<<<<<<< HEAD
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();


=======
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();         
>>>>>>> 898d7d1fb4536466984ff56d988dfeebfd378ea1
        }

        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            this.companyEmpWaeList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(company, companyEmpWage);
<<<<<<< HEAD

=======
>>>>>>> 898d7d1fb4536466984ff56d988dfeebfd378ea1
        }

        public void computeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWaeList)
            {
                companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());
            }
        }
<<<<<<< HEAD

        private int computeEmpWage(CompanyEmpWage companyEmpWage)
=======
>>>>>>> 898d7d1fb4536466984ff56d988dfeebfd378ea1

        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
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
                Console.WriteLine("Day : " + totalWorkingDays + "Emp Hrs : " + empHrs);
            }
            companyEmpWage.dailyWage = empHrs * companyEmpWage.empRatePerHour;
            companyEmpWage.TotalWageAlongWithDailyWage = totalEmpHrs * companyEmpWage.empRatePerHour + companyEmpWage.dailyWage;
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }
<<<<<<< HEAD
    

       
=======
        
>>>>>>> 898d7d1fb4536466984ff56d988dfeebfd378ea1
        public int getTotalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalEmpWage;
        }
    }
}
