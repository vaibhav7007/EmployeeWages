using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class EmployeeWagesUC8
    {
        public const int IS_PARTTIME = 1;
        public const int IS_FULLTIME = 2;

        //Created method Employee wage UC6 & UC7
        public static int EmployeeUC8(string company, int empRatePerHrs, int maxWorkingdays, int maxHrsPerMonth)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs < maxHrsPerMonth && totalWorkingDays < maxWorkingdays)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                totalWorkingDays++;
                switch (empCheck)
                {
                    case 1:
                        empHrs = 4;
                        break;
                    case 2:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                totalEmpHrs = totalEmpHrs + empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs: " + empHrs);
            }
            int totalEmpWages = totalEmpHrs * empRatePerHrs;
            Console.WriteLine("Total Employee wages:" + totalEmpWages);
            return totalEmpWages;
        }
    }
}
