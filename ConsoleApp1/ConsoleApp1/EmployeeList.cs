using System;
using System.Collections.Generic;
using System.Text;

namespace MaternityDepartment
{
    public class EmployeeList
    {

        List<Employee> employees = new List<Employee>();


        public void AddToList(Employee Employees)
        {
            employees.Add(Employees);

        }
    }
}
