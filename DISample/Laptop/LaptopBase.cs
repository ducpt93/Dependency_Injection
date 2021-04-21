using DISample.Cpu.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DISample.Laptop
{
    internal abstract class LaptopBase
    {
        public LaptopManufature LaptopManufature { get; set; }
        public ICpu Cpu { get; }

        public LaptopBase(ICpu cpu, LaptopManufature manufature)
        {
            Cpu = cpu;
            LaptopManufature = manufature;
        }

        public abstract void TryReplaceCpu();
    }
}
