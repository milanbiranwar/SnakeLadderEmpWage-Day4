using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class EmployeeWageUC3
    {
        public static void EmployeeWage()
        {
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int emphrs = 0;
            int empwage = 0;
            Random obj = new Random();
            int num = obj.Next(0, 3);
            if (num == IS_FULL_TIME)
            {
                emphrs = 12;
            }
            else if (num == IS_PART_TIME)
            {
                emphrs = 8;
            }
            else
            {
                emphrs = 0;
            }
            empwage = emphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("The Employee wage of the day is :" + empwage);
        }
    }
}
