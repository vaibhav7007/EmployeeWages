using System;

namespace EmployeeWages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter option given below");
            Console.WriteLine("1:UC1 Employee is present or absent");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Random random = new Random();
                    int empCheck = random.Next(0, 2);
                    EmployeeWagesUC1.EmployeeUC1(empCheck);
                    break;
                }
            }
    }
}
