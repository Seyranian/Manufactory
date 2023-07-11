using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufactory
{
    internal class Director : Employee
    {
        public override void GetEmployeeInformation()
        {
            Console.WriteLine($"Position - {position}\nName - {name}\nGender - {gender}");
            Console.WriteLine("-----------------------------");
        }
    }
}
