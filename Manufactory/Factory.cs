using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufactory
{
    internal class Factory
    {
        List<Employee> employees = new List<Employee>();
        public Factory(params Employee[] newEmployees)
        {
            foreach (var employee in newEmployees)
            {
                employees.Add(employee);
            }
        }
        public void AddNewEmployee(Employee employee)
        {
            if (!employees.Contains(employee))
            {
                employees.Add(employee);
            }
        }
        public void GetEmploees()
        {
            foreach (var employee in employees)
            {
                employee.GetEmployeeInformation();
            }
        }
    }
}
