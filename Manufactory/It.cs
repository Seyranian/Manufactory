using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufactory
{
    internal class ItSection
    {
        public ProgrammingLevel programmingLevel;
        public void GetSectionInformation()
        {
            Console.WriteLine($"Programming Level - {programmingLevel}");
        }
    }
    public enum ProgrammingLevel
    {
        intern,
        junior,
        middle,
        senior
    }
}
