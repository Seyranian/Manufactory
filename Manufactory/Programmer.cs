using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufactory
{
    internal class Programmer : Employee
    {
        public ItSection section;
        public override void GetEmployeeInformation()
        {
            section.GetSectionInformation();
            Console.WriteLine($"Section - {section}");
            base.GetEmployeeInformation();
        }
    }
}
