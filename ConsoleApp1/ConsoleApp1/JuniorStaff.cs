using System;
using System.Collections.Generic;
using System.Text;

namespace MaternityDepartment
{
    class JuniorStaff : Employee

    {
        public JuniorStaff(string employeeFullname, int employeeId, double employeeSalary, double startHour, double endHour, double hourlyRate, double extraRate, double riskRate, bool isSenior) :
            base(employeeFullname, employeeId, employeeSalary, startHour, endHour, hourlyRate, extraRate, riskRate, isSenior)
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
