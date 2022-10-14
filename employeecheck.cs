using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeewage_day3
{
    public static class employeecheck
    {
        public static void CheckAttendance()
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empcheck = random.Next(2);
            if (empcheck == IS_FULL_TIME)
            {
                Console.WriteLine("employee is present");
            }
            else
            {
                Console.WriteLine("employee is absent");
            }
        }
    }
}

