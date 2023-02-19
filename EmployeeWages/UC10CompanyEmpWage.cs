using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class UC10CompanyEmpWage
    {
        public string company;
        public int empRatePerHr;
        public int maxWorkingDays;
        public int maxHrsPerMonth;
        public int totalEmpWages;
        public UC10CompanyEmpWage(string company, int empRatePerHr, int maxWorkingDays, int maxHrsPerMonth)
        {
            this.company = company;
            this.empRatePerHr = empRatePerHr;
            this.maxWorkingDays = maxWorkingDays;
            this.maxHrsPerMonth = maxHrsPerMonth;
        }
        public void SetTotalEmpWages(int totalEmpWages)
        {
            this.totalEmpWages = totalEmpWages;
        }
        public string ToString()
        {
            return "Total Emp Wage for company: " + this.company + " is: " + this.totalEmpWages;
        }
    }
}
