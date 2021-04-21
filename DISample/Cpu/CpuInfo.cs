using System;
using System.Collections.Generic;
using System.Text;

namespace DISample.Cpu
{
    internal class CpuInfo
    {
        public string Name { get; set; }
        public CpuManufacture Manufature { get; set; }
        public int CoreNumber { get; set; }
        public int ThreadNumber { get; set; }

        public string CoreSpeed { get; set; }
    }
}
