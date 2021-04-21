using DISample.Cpu;
using System;
using System.Collections.Generic;
using System.Text;
using DISample.Laptop;

namespace DISample.Cpu.Interfaces
{
    internal interface ICpu
    {
        CpuInfo CpuInfo { get; set; }

        bool IsSupport(LaptopBase laptop);
    }
}
