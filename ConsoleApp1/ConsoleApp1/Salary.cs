using System;
using System.Collections.Generic;
using System.Text;

namespace MaternityDepartment
{
    public class Salary
    {
        public double HourlyRate { get; set; }
        public double NumberOfHours { get; set; }
        public double ExtraRate { get; set; }
        public double RiskRate { get; set; }
        public double EmployeeSalary { get; set; }

        public double MinorSalary()
        {
            double hourlyRate = HourlyRate;
            double numberOfHours = NumberOfHours;
            double employeeSalary = hourlyRate * numberOfHours;
            EmployeeSalary = employeeSalary;
            return EmployeeSalary;
        }

        public double SeniorSalary()
        {
            double hourlyRate = HourlyRate;
            double numberOfHours = NumberOfHours;
            double extraRate = ExtraRate;
            double employeeSalary = (extraRate * hourlyRate) * numberOfHours;
            EmployeeSalary = employeeSalary;
            return EmployeeSalary;
        }

        public double ExpertSalary()
        {
            double hourlyRate = HourlyRate;
            double numberOfHours = NumberOfHours;
            double extraRate = ExtraRate;
            double employeeSalary = (extraRate * hourlyRate) * numberOfHours;
            EmployeeSalary = employeeSalary;
            return EmployeeSalary;
        }

        public double DecisionMakingSalary()
        {
            double hourlyRate = HourlyRate;
            double numberOfHours = NumberOfHours;
            double extraRate = ExtraRate;


            if (numberOfHours > 50)
            {
                numberOfHours = 200;
                double employeeSalary = (extraRate * hourlyRate) * numberOfHours;
                EmployeeSalary = employeeSalary;
                return EmployeeSalary;
            }
            else
            {
                double employeeSalary = (extraRate * hourlyRate) * numberOfHours;
                EmployeeSalary = employeeSalary;
                return EmployeeSalary;
            }
        }
        public double GlobalSalary { get; set; }
        public double SalaryCalculation()
        {
            double globalSalary = GlobalSalary;
            double employeeSalary = globalSalary;
            EmployeeSalary = employeeSalary;
            return EmployeeSalary;
        }

        public double RiskSalary()
        {
            double employeeSalary = EmployeeSalary;
            double riskrate = RiskRate;
            employeeSalary = employeeSalary * riskrate;
            EmployeeSalary = employeeSalary;
            return EmployeeSalary;

        }



    }
}
