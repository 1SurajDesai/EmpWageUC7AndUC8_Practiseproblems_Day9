using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProblemUC7AndUC8
{
    public class RefactorCodeToComputeWage
    {
        public const int IsPartTime = 1;
        public const int IsFullTime = 2;
        public const int EmpRatePerHr = 20;
        public const int NoOfDaysInMonth = 20;
        public const int MaxRateInMonth = 100;
        
        public void ComputeEmpWage()
        {
            int EmpHr = 0, TotalEmpHr = 0, TotalWorkingDays = 0;    
            while (TotalEmpHr <= MaxRateInMonth && TotalWorkingDays < NoOfDaysInMonth)
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
            Console.WriteLine("Salary for month is " + salary);
        }
    }
}
