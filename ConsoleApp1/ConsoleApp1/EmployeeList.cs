using System;
using System.Collections.Generic;
using System.Text;

namespace MaternityDepartment
{
    public class EmployeeList
    {

        List<Employee> employees = new List<Employee>();


        public void AddToList(Employee employee)
        {
            employees.Add(employee);

        }

        public void CheckInEmployeeList(Employee employee)
        {
            bool employeeInList = employees.Contains(employee);
            if  (employeeInList == true)
            {

             

            }
            else
            {
                Console.WriteLine("Employee name:" + employee + "is'nt registered to the system");
            }
        }
    }
}
