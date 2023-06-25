using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_EmpWage
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmployeeCheck emp = new EmployeeCheck();
            string ans = "";
            do
            {
                Console.WriteLine(" 1:Check Emp Avalability \n 2: Check Daily Wage \n 3: PartTime_FullTime_Emp \n 4: PartTime FullTime Emp Using SwitchCase");
                Console.WriteLine("Enter the choice");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        emp.CheckEmp();
                        break;
                    case 2:
                        emp.DailyWage();
                        break;
                    case 3:
                        emp.PartTime_FullTime_Emp();
                        break;
                    case 4:
                        emp.PartTime_FullTime_Emp_Using_SwitchCase();
                        break;
                    default:
                        Console.WriteLine("Please insert valid number");
                        break;
                }
                Console.WriteLine("Do you want to Continue ?");
                ans = Console.ReadLine();
            } while (ans == "yes" || ans == "y");
        }
    }
}
