using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class EmployeeWagesUC4
    {
        public static void EmployeeUC4(int empCheck3)
        {
            int IS_FULLTIME = 1;
            int IS_PARTTIME = 2;
            int EMP_RATE_PER_HRS = 20;

            int empHrs = 0;
            int empWages = 0;

            if (empCheck3 == IS_FULLTIME)
            {
                empHrs = 8;
                Console.WriteLine("Employee is present and doing Fulltime");
            }
            else if (empCheck3 == IS_PARTTIME)
            {
                empHrs = 4;
                Console.WriteLine("Employee is present and doing Parttime");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is absent");
            }
            empWages = empHrs * EMP_RATE_PER_HRS;
            Console.WriteLine("Employee wages:" + empWages);

        }
    }
}
