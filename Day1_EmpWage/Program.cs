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

            Console.WriteLine("1:Check Emp Avalability");
            Console.WriteLine("Enter the choice");
            int choice=int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    emp.CheckEmp();
                    break;
                default:
                    Console.WriteLine("Please insert valid number");
                    break;
            }
        }
    }
}
