using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProblemUC7AndUC8
{
    public class EmpWageForMultipleCompanies
    {
        public const int IsPartTime = 1;
        public const int IsFullTime = 2;
        
        public void ComputeEmpWage(string Company, int EmpRatePerHr, int NoOfWorkingDays, int MaxRateInMonth)
        {
            int EmpHr = 0, TotalEmpHr = 0, TotalWorkingDays = 0;
            while (TotalEmpHr <= MaxRateInMonth && TotalWorkingDays < NoOfWorkingDays)
            {
                TotalWorkingDays++;
                Random random = new Random();
                int EmpCheck = random.Next(3);
                switch (EmpCheck)
                {
                    case IsPartTime:
                        EmpHr = 4;
                        break;
                    case IsFullTime:
                        EmpHr = 8;
                        break;
                    default:
                        EmpHr = 0;
                        break;
                }
                TotalEmpHr += EmpHr;

            }
            int salary = TotalEmpHr * EmpRatePerHr; 
            Console.WriteLine("Total salary for company " + Company + " is " + salary);
        }
    }
}
