using System;
using System.Collections.Generic;
using System.Text;

namespace MaternityDepartment
{
    public abstract class Employee
    {
        public abstract string EmployeeFullName { get; set; }
        public abstract int EmployeeId { get; set; }
        public abstract double EmployeeSalary { get; set; }
        public abstract double StartHour { get; set; }
        public abstract double EndHour { get; set; }
        public abstract double HourlyRate { get; set; }
        public abstract double ExtraRate { get; set; }
        public abstract double RiskRate { get; set; }
        public abstract bool is
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
        
        

        public Employee()//string employeeFullname, int employeeId, int employeePhoneNumber,  double employeeSalary)
        {
            //EmployeeFullName = employeeFullName;
            //EmployeeId = employeeId;
            //EmployeePhoneNumber = employeePhoneNumber;
            //EmployeeSalary = employeeSalary;
        }
    }
}
