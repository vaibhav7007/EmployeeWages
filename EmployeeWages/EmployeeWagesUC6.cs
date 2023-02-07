using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class EmployeeWagesUC6
    {
        const int IS_PARTTIME = 1;
        const int IS_FULLTIME = 2;
        const int EMP_RATE_PER_HRS = 20;
        const int MAX_WORKING_DAYS = 20;
        const int MAX_RATE_IN_MONTH = 100;

        public static void EmployeeUC6(int empCheck5)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs < MAX_RATE_IN_MONTH && totalWorkingDays < MAX_WORKING_DAYS)
            {
                totalWorkingDays++;
                switch (empCheck5)
                {
                    case 1:
                        Console.WriteLine("PART TIME");
                        empHrs = 4;
                        break;
                    case 2:
                        Console.WriteLine("FULLTIME");
                        empHrs = 8;
                        break;
                    default:
                        Console.WriteLine("Absent");
                        empHrs = 0;
                        break;
                }

                totalEmpHrs = totalEmpHrs + empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs: " + empHrs);
            }
            int totalEmpWages = totalEmpHrs * EMP_RATE_PER_HRS;
            Console.WriteLine("Total Employee wages:" + totalEmpWages);
        }
    }
}
