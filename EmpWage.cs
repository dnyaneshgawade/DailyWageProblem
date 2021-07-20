using System;
using System.Collections.Generic;
using System.Text;

namespace DailyWageProblem
{
    public class EmpWage
    {
        const int Wage_Per_Hr = 20;
        const int WORKING_DAYS = 20;
        int payment = 0;
        int workHr;

        public void monthlyWage()
        {
            Random random = new Random();
            int num = random.Next(0, 3);
            switch (num)
            {
                case 0:
                    Console.WriteLine("Monthly wage of fulltime employee");
                    workHr = 8;
                    break;
                case 1:
                    Console.WriteLine("Monthly wage of parttime employee");
                    workHr = 4;
                    break;
                default:
                    Console.WriteLine("employee is absent");
                    break;
            }
            payment = Wage_Per_Hr * workHr * WORKING_DAYS;
            Console.WriteLine("Payment is:" + payment);
        }
    }
}
