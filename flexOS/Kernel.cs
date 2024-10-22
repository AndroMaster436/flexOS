using System;
using Sys = Cosmos.System;

namespace FlexOS
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.Clear();
            Console.WriteLine(@"""
               __ _            ____   _____ 
  / _| |          / __ \ / ____|
 | |_| | _____  _| |  | | (___  
 |  _| |/ _ \ \/ / |  | |\___ \ 
 | | | |  __/>  <| |__| |____) |
 |_| |_|\___/_/\_\\____/|_____/ 
                                
                                """);
            Console.WriteLine("Welcome to flexOS\nType help for command list");
        }

        protected override void Run()
        {
            while (true)
            {
                Console.Write("root@flexOS> ");
                var cmd = Console.ReadLine();
                switch (cmd)
                {
                    default:
                        Console.WriteLine($"Incorrect command: {cmd}");
                        break;
                }
            }
        }
    }
}