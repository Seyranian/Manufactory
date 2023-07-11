using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufactory
{
    internal abstract class Employee
    {
        public string position;
        public string name;
        public int age;
        public int id;
        public string phoneNumber;
        public string email;
        public Gender gender;
        public int salary;
        public virtual void GetEmployeeInformation()
        {
            Console.WriteLine($"Position - {position}\nName - {name}\nAge - {age}\nId - {id}\nPhone Number - {phoneNumber}\nEmail - {email}\nGender - {gender}\nSalary - {salary}");
            Console.WriteLine("-----------------------------");
        }
    }
    public enum Gender
    {
        male,
        female
    }
}
