using System;
using System.Collections.Generic;
using System.Text;
using DISample.Cpu.Interfaces;
using DISample.Laptop;

namespace DISample.Cpu
{
    internal class IntelCpu : ICpuIntel
    {
        public CpuInfo CpuInfo { get; set; }

        public IntelCpu()
        {
            CpuInfo = new CpuInfo
            {
                Manufature = CpuManufacture.Intel,
                Name = "Core I7",
                CoreNumber = 4,
                ThreadNumber = 8,
                CoreSpeed = "4 Ghz"
            };
        }

        public bool IsSupport(LaptopBase laptop)
        {
            //support Acer, Asus
            return laptop.LaptopManufature == LaptopManufature.Acer ||
                 laptop.LaptopManufature == LaptopManufature.Asus;
        }
    }
}
