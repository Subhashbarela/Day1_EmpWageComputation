using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day1_EmpWage
{
    internal class EmployeeCheck
    {
        public void CheckEmp()
        {
            int Emp_is_present = 1;
            Random random = new Random();
            int empCheck = random.Next(2);
            if (empCheck == Emp_is_present)
            {
                Console.WriteLine("employee is present");
            }
            else
            {
                Console.WriteLine("employee is absent");
            }
        }
        public void DailyWage()
        {
            int Is_Full_Time = 1;
            int Emp_Rate_Per_Hour = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = (random.Next(2));
            if (empHrs == Is_Full_Time)
            {
                empHrs = 8;
            }
            else
            {
                Console.WriteLine(" Employee is Absent.....");
                empHrs = 0;
            }
            empWage = empHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Employee Wage is :" + empWage);
        }
        public void PartTime_FullTime_Emp()
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int FULL_TIME_HR = 8;
            const int PART_TIME_HR = 4;
            const int WAGE_PER_HR = 20;
            int empHrs = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            if (empCheck == IS_FULL_TIME)
            {

                Console.WriteLine("Full Time Employee");
                empHrs = FULL_TIME_HR;

            }
            else if (empCheck == IS_PART_TIME)
            {
                Console.WriteLine("Part Time Employee");
                empHrs = PART_TIME_HR;

            }
            else
            {
                Console.WriteLine("Employee is absent");
                empHrs = 0;

            }
            int empWage = empHrs * WAGE_PER_HR;
            Console.WriteLine("EmpWage Is : " + empWage);
        }
        public void PartTime_FullTime_Emp_Using_SwitchCase()
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int FULL_TIME_HR = 8;
            const int PART_TIME_HR = 4;
            const int WAGE_PER_HR = 20;
            int empHrs = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            switch (empCheck)
            {
                case IS_FULL_TIME:
                    {
                        Console.WriteLine("Full Time Employee");
                        empHrs = FULL_TIME_HR;
                        break;
                    }
                case IS_PART_TIME:
                    {
                        Console.WriteLine("Part Time Employee");
                        empHrs = PART_TIME_HR;
                        break;
                    }
                default:
                    Console.WriteLine("Employee is absent");
                    empHrs = 0;
                    break;
            }
            int empWage = empHrs * WAGE_PER_HR;
            Console.WriteLine("EmpWage Is : " + empWage);
        }
        public void Calculate_Wage_ForMonth()
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int FULL_TIME_HR = 8;
            const int PART_TIME_HR = 4;
            const int WAGE_PER_HR = 20;
            const int DAY_OF_MONTH = 10;
            int TotalWage = 0;

            int empHrs = 0;
            Random random = new Random();

            for (int i = 1; i <= DAY_OF_MONTH; i++)
            {
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        {
                            Console.WriteLine("Full Time Employee");
                            empHrs = FULL_TIME_HR;
                            break;
                        }
                    case IS_PART_TIME:
                        {
                            Console.WriteLine("Part Time Employee");
                            empHrs = PART_TIME_HR;
                            break;
                        }
                    default:
                        Console.WriteLine("Employee is absent");
                        empHrs = 0;
                        break;
                }
                int empWage = empHrs * WAGE_PER_HR;
                Console.WriteLine("EmpWage is Day {0} is : {1} : ", i, empWage);
                TotalWage += empWage;
            }
            Console.WriteLine("Total Emp Wage  is : " + TotalWage);

        }
        public void CalWageUsingCondition()
        {
            const int Emp_Rate_Per_Hour = 20;
            const int Is_Full_Time = 1;
            const int Is_Part_Time = 2;
            const int WORKING_DAYS = 20;
            const int MAX_HRS_IN_MONTH = 100;


            int EmpHrs = 0, TotalEmpWage = 0, TotalEmpHrs = 0, TotalEmpWages = 0;
            int TotalWorkingDays = 0;

            while (TotalEmpHrs <= MAX_HRS_IN_MONTH && TotalWorkingDays < WORKING_DAYS)
            {
                TotalWorkingDays++;
                Random random = new Random();
                int EmpCheck = (random.Next(3));
                switch (EmpCheck)
                {
                    case Is_Full_Time:
                        EmpHrs = 8;
                        break;

                    case Is_Part_Time:
                        EmpHrs = 4;
                        break;
                    default:
                        EmpHrs = 0;
                        break;
                }
                TotalEmpHrs += EmpHrs;
                Console.WriteLine(" Days :" + TotalWorkingDays + " Emp Hours :" + EmpHrs);
            }
            TotalEmpWage = Emp_Rate_Per_Hour * TotalEmpHrs;
            Console.WriteLine(" Employee Total Wage :" + TotalEmpWage);
        }
    }
}
