using System;

namespace EmployeeWages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter option given below");
            Console.WriteLine("1:UC1 Employee is present or absent\n2:UC2 Employee Wage");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Random random = new Random();
                    int empCheck = random.Next(0, 2);
                    EmployeeWagesUC1.EmployeeUC1(empCheck);
                    break;

                case 2:
                    Random random1 = new Random();
                    int empCheck1 = random1.Next(0, 2);
                    EmployeeWagesUC2.EmployeeUC2(empCheck1);
                    break;
                }
            }
    }
}
