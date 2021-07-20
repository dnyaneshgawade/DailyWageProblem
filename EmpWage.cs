using System;
using System.Collections.Generic;
using System.Text;

namespace DailyWageProblem
{
    public class EmpWage
    {
        public const int WAGE_PER_HR = 20;
        public const int PART_TIME_HR = 4;
        public const int FULL_TIME_HR = 8;
        public void find()
        {
            int dailyWage = WAGE_PER_HR * FULL_TIME_HR;
            Console.WriteLine("daily wage=" + dailyWage);
        }

    }
}
