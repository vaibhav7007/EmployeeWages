using System;

namespace EmployeeWages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter option given below");
            Console.WriteLine("1:UC1 Employee is present or absent\n2:UC2 Employee Wage\n3:UC3 Employee Wgaes\n4:UC4 Employee wage\n5:UC5 Employee wage\n6:UC6 Employee wage\n7:Refactor Employee wage UC7\n8:Refactor to compute multiple company wages");
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

                case 3:
                    Random random2 = new Random();
                    int empCheck2 = random2.Next(0, 3);
                    EmployeeWagesUC3.EmployeeUC3(empCheck2);
                    break;

                case 4:
                    Random random3 = new Random();
                    int empCheck3 = random3.Next(0, 3);
                    EmployeeWagesUC4.EmployeeUC4(empCheck3);
                    break;

                case 5:
                    Random random4 = new Random();
                    int empCheck4 = random4.Next(0, 3);
                    EmployeeWagesUC5.EmployeeUC5(empCheck4);
                    break;

                case 6:
                    Random random5 = new Random();
                    int empCheck5 = random5.Next(0, 3);
                    EmployeeWagesUC6.EmployeeUC6(empCheck5);
                    break;
                case 7:
                    Random random6 = new Random();
                    int empCheck6 = random6.Next(0, 3);
                    EmployeeWagesUC6.EmployeeUC6(empCheck6);
                    break;

                case 8:
                    EmployeeWagesUC8.EmployeeUC8("Jio", 20, 2, 10);
                    EmployeeWagesUC8.EmployeeUC8("Airtel", 10, 4, 20);
                    break;

            }
            }
    }
}
