using System;
using System.Collections.Generic;
using System.Text;

namespace MaternityDepartment
{
    public abstract class Employee
    {
        public string EmployeeFullName { get; set; }
        public  int EmployeeId { get; set; }
        public  double EmployeeSalary { get;  }
        public  double StartHour { get; set; }
        public double EndHour { get; set; }
        public  double HourlyRate { get; set; }
        public double ExtraRate { get; set; }
        public double RiskRate { get; set; }
        public bool IsSenior { get; set; }
        public string EmployeeType;
        

        public Employee (string employeeFullname, int employeeId, double employeeSalary, double startHour, double endHour, double hourlyRate, double extraRate, double riskRate, bool isSenior)
        {
            EmployeeFullName = employeeFullname;
            EmployeeId = employeeId;
            EmployeeSalary = employeeSalary;
            StartHour = startHour;
            EndHour = endHour;
            HourlyRate = hourlyRate;
            ExtraRate = extraRate;
            RiskRate = riskRate;
            IsSenior = isSenior;
        }


}
}
