using System;
using System.Collections.Generic;
using System.Text;

namespace DailyWageProblem
{
    public class EmpWage
    {
        const int Wage_Per_Hr = 20;
        public const int PART_TIME_HR = 4;
        public const int FULL_TIME_HR = 8;
        int MAX_WORKING_DAYS = 20;
        int fPayment;
        int hPayment;

        public void wage()
        {
            for (int i = 1; i <= MAX_WORKING_DAYS; i++)
            {
                int working_day = i;
                fPayment = Wage_Per_Hr * FULL_TIME_HR * working_day;
                Console.WriteLine("full time Payment of day" + i + " is:" + fPayment);
                hPayment = Wage_Per_Hr * PART_TIME_HR * working_day;
                Console.WriteLine("part time Payment of day" + i + " is:" + hPayment);
            }

        }
    }
}
