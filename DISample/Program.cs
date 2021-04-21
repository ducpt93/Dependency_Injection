using Autofac;
using DISample.Cpu;
using DISample.Cpu.Interfaces;
using DISample.DIContainer;
using DISample.Laptop;
using System;

namespace DISample
{
    internal class Program
    {
        private static IDIContainer _dIContainer = RegisterDI();
        private static IContainer _container { get; set; }
        private static void Main(string[] args)
        {
            /* 1.manual
            icpu cpu = new intelcpu();
            laptopbase lap = new acerlaptop(cpu);
            lap.tryreplacecpu();
            console.writeline(" ");
            lap = new delllaptop(cpu);
            lap.tryreplacecpu();
            console.readkey();
            */


            /*2. DI COntainer Example
            ICpu cpu = _dIContainer.Resolve<ICpuIntel>();
            LaptopBase laptop = new AcerLaptop(cpu);
            laptop.TryReplaceCpu();

            Console.WriteLine("-------");

            cpu = _dIContainer.Resolve<ICpuAmd>();
            laptop = new DellLaptop(cpu);
            laptop.TryReplaceCpu();

            Console.WriteLine("----------");

            laptop = new AsusLaptop(cpu);
            laptop.TryReplaceCpu();

            Console.ReadKey();*/

           // 3. using Aotofac third party
            var builder = new ContainerBuilder();
            builder.RegisterType<IntelCpu>().As<ICpuIntel>();
            builder.RegisterType<AmdCpu>().As<ICpuAmd>();
            _container = builder.Build();

            using (var scope = _container.BeginLifetimeScope())
            {
                var cpu = scope.Resolve<ICpuIntel>();
                var laptop = new DellLaptop(cpu);
                laptop.TryReplaceCpu();

                var laptop2 = new AsusLaptop(cpu);
                laptop2.TryReplaceCpu();

                var cpu2 = scope.Resolve<ICpuAmd>();

                laptop = new DellLaptop(cpu2);
                laptop.TryReplaceCpu();

                 laptop2 = new AsusLaptop(cpu2);
                laptop2.TryReplaceCpu();

                Console.ReadKey();


            }
        }
        private static IDIContainer RegisterDI()
        {
            IDIContainer container = new SampleDICOntainer();
            container.Register<ICpuIntel, IntelCpu>();
            container.Register<ICpuAmd, AmdCpu>();
            return container;
        }
    }
}