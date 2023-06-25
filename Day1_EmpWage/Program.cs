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
            EmpWageComputation emp = new EmpWageComputation();
            string ans = "";
            do
            {
                Console.WriteLine(" 1:Check Emp Avalability \n 2: Check Daily Wage \n 3: PartTime_FullTime_Emp \n 4: PartTime FullTime Emp Using SwitchCase " +
                    "\n 5: Calculate_Wage_ForMonth \n 6: Calculate Wage Using Condition");
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
                    case 5:
                        emp.Calculate_Wage_ForMonth();
                        break; 
                    case 6:
                        emp.CalWageUsingCondition();
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
