using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class EmployeeWage
    {
        
        const int EMP_RATE_PER_HR = 20;
        const int FULL_TIME_HR = 8;
        int totalWage = 0;

        public void dailyWage()
        {
            Random rd = new Random();
            int empCheck = rd.Next(0, 2);
            if (empCheck == 0)
                totalWage = EMP_RATE_PER_HR * FULL_TIME_HR;
            else
                totalWage = 0;
            Console.WriteLine("Employee daily wage is:" + totalWage);
        }
    }
}