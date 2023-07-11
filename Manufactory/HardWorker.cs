using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufactory
{
    internal class HardWorker : Employee
    {
        public HardWorkerSection section;
        public override void GetEmployeeInformation()
        {
            section.GetSectionInformation();
            Console.WriteLine($"Section - {section}");
            base.GetEmployeeInformation();
        }
    }
}
