using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class UC10EmployeeWageBuilder
    {
        public const int IS_PARTTIME = 1;
        public const int IS_FULLTIME = 2;

        public int numOfCompany = 0;
        public UC10CompanyEmpWage[] companyEmpWageArray;
        public UC10EmployeeWageBuilder()
        {
            this.companyEmpWageArray = new UC10CompanyEmpWage[5];
        }
        public void AddCompanyEmpwage(string company, int empRatePerHr, int numOfWorkingDays, int maxHrsPerMonth)
        {
            companyEmpWageArray[this.numOfCompany] = new UC10CompanyEmpWage(company, empRatePerHr, numOfWorkingDays, maxHrsPerMonth);
            numOfCompany++;
        }
        public void ComputeEmpWageForCompany()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].SetTotalEmpWages(this.ComputeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].ToString());
            }
        }
        public int ComputeEmpWage(UC10CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs < companyEmpWage.maxHrsPerMonth && totalWorkingDays < companyEmpWage.maxWorkingDays)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                totalWorkingDays++;
                switch (empCheck)
                {
                    case IS_PARTTIME:
                        empHrs = 4;
                        break;
                    case IS_FULLTIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                totalEmpHrs = totalEmpHrs + empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs: " + empHrs);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHr;
        }
    }
}
