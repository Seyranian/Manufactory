using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Manufactory
{
    internal class HardWorkerSection
    {
        public KindsOfHardWork kindOfHardWork;
        public void GetSectionInformation()
        {
            Console.WriteLine($"Kind of hard work - {kindOfHardWork}");
        }
    }
    public enum KindsOfHardWork
    {
        stoneThrower,
        cemmentThrower,
        pianoThrower
    }
}
