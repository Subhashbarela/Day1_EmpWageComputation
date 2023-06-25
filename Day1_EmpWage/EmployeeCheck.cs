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
    }
}
