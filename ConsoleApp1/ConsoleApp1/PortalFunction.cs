using System;
using System.Collections.Generic;
using System.Text;

namespace MaternityDepartment
{
    class PortalFunction
    {
        List<Employee> employees;

        public PortalFunction(List<Employee> employees)
        {
            this.employees = employees;
        }

        public void AddToListGivenEmployeeName()
        {
            Console.WriteLine("Enter your name please:");
            string employeeFullname = Console.ReadLine();
            Console.WriteLine("Enter your Id please:");
            int employeeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your salary please:");
            double employeeSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your startHour please:");
            double startHour = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your salary please:");
            double employeeSalary = Convert.ToDouble(Console.ReadLine());
            employees.AddToList(employeeFullname, employeeId, employeeSalary, startHour, endHour, hourlyRate, extraRate, riskRate, isSenior);
            
        }
    }
}
