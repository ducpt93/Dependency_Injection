using DISample.Cpu.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DISample.Laptop
{
    internal class AcerLaptop : LaptopBase
    {
        public AcerLaptop(ICpu cpu) : base(cpu, LaptopManufature.Acer)
        { 
        }

        public override void TryReplaceCpu()
        {
            if (Cpu.IsSupport(this))
            {
                Console.WriteLine($"Great!, Cpu of '{Cpu.CpuInfo.Manufature }' can use for '{this.LaptopManufature}'");
            }
            else
            {
                Console.WriteLine($"Bored!, Cpu of '{Cpu.CpuInfo.Manufature }' can't use for '{this.LaptopManufature}'");
            }
        }
    }
}
