using System;
using System.Collections.Generic;

namespace Exercise10
{
    public class Employee
    {
        public string EmpName { get; set; }

        public Employee(string name)
        {
            EmpName = name;
        }

        public virtual double CalcPaidCheck()
        {
            return 0;
        }
    }

    public class HourlyWorker : Employee
    {
        public double HoursWorked { get; set; }
        public double HourlyRate { get; set; }

        public HourlyWorker(string name, double hoursWorked, double hourlyRate ) : base(name)
        {
            HoursWorked = hoursWorked;
            HourlyRate = hourlyRate;
        }


        public override double CalcPaidCheck()
        {
            return HourlyRate * HoursWorked;
        }
    }

    public class SalaryWorker : Employee
    {
        public double AnnualSalary { get; set; }

        public SalaryWorker(string name, double annualSalary) : base(name)
        {
            AnnualSalary = annualSalary;
        }

        public override double CalcPaidCheck()
        {
            return AnnualSalary / 12;
        }
    }

}
