using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class EmployeeWageUC5
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int EMP_RATE_PER_HOUR = 20;
        public static void EmployeeWageofMonth()
        {
            int emphrs = 0;
            int empwage = 0;
            int totalEmpWage = 0;
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random obj = new Random();
                int num = obj.Next(0, 3);
                switch (num)
                {
                    case IS_FULL_TIME:
                        emphrs = 12;
                        break;
                    case IS_PART_TIME:
                        emphrs = 8;
                        break;
                    default:
                        emphrs = 0;
                        break;

                }
                empwage = emphrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empwage;
                Console.WriteLine("Emp wage :" + empwage);
            }
            Console.WriteLine("Total Emp Wage :" + totalEmpWage);

        }
    }
}
