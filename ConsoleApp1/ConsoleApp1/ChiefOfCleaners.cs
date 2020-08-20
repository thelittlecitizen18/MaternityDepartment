using System;
using System.Collections.Generic;
using System.Text;

namespace MaternityDepartment
{
    class ChiefOfCleaners : Cleaner
    {
        public ChiefOfCleaners(string employeeFullname, int employeeId, double employeeSalary, double startHour, double endHour, double hourlyRate, double extraRate, double riskRate, bool isSenior) :
            base(employeeFullname, employeeId, employeeSalary, startHour, endHour, hourlyRate, extraRate, riskRate, isSenior)
        {
       
        }
    }
}
