using System;
using System.Collections.Generic;
using System.Text;
using DISample.Cpu.Interfaces;
using DISample.Laptop;

namespace DISample.Cpu
{
    internal class AmdCpu : ICpuAmd
    {
        public CpuInfo CpuInfo { get; set; }

        public AmdCpu()
        {
            CpuInfo = new CpuInfo
            {
                Manufature = CpuManufacture.Amd,
                Name = "Core I9",
                CoreNumber = 4,
                ThreadNumber = 8,
                CoreSpeed = "4 Ghz"
            };
        }

        public bool IsSupport(LaptopBase laptop)
        {
            //support Del
            return laptop.LaptopManufature == LaptopManufature.Del;
        }
    }
}
