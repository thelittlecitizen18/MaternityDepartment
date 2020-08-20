using System;
using System.Collections.Generic;
using System.Text;

namespace MaternityDepartment
{
    public abstract class Employee
    {
        public string EmployeeFullName { get; set; }
        public  int EmployeeId { get; set; }
        public  double EmployeeSalary { get; set; }
        public  double StartHour { get; set; }
        public double EndHour { get; set; }
        public  double HourlyRate { get; set; }
        public double ExtraRate { get; set; }
        public double RiskRate { get; set; }
        public bool IsSenior { get; set; }
        public enum EmployeeType
        {
            Clearner,
            ToxicCleaner,
            MultiCleaners,
            CleanerShitManager,
            Cooker,
            ChefAsistent,
            Chef,
            FoodDistributor,
            ChiefOfStuff,
            Nersue,
            Trainee,
            Medic,
            Paramedic,
            HeadOfNurses,
            Midwife,
            SpecialMidwife,
            SpeialTrainee,
            Doctor,
            Expert,
            ViceHeadOfDepartment,
            HeadOfDepartment,
        }
        
        

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
