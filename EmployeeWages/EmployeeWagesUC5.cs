using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class EmployeeWagesUC5
    {
        public const int IS_PARTTIME = 1;
        public const int IS_FULLTIME = 2;
        public const int EMP_RATE_PER_HRS = 20;
        public const int MAX_WORKING_DAYS = 20;

        public static void EmployeeUC5(int empCheck4)
        {
            int empHrs = 0;
            int empWages = 0;
            int totalWages = 0;
            int day = 1;

            for (day = 1; day <= MAX_WORKING_DAYS; day++)
            {
                switch (empCheck4)
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

                empWages = empHrs * EMP_RATE_PER_HRS;
                Console.WriteLine("Employee wages:" + empWages);

                totalWages = totalWages + empWages;
                Console.WriteLine("Total monthly wages of an employee is: " + totalWages);
            }
        }
    }
}