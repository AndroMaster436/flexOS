using System;
using Sys = Cosmos.System;

namespace FlexOS
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("Hello World");
        }

        protected override void Run()
        {
            while (true)
            {
                // nothing
            }
        }
    }
}