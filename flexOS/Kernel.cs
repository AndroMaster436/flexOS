namespace FlexOS;

using System;
using Sys = Cosmos.System;
using System.Reflection;
using Microsoft.VisualBasic;

public class Kernel : Sys.Kernel
{
    protected override void BeforeRun()
    {
        BootManager.Init();
        DriversManager.Init();
    }

    protected override void Run()
    {
        var bootMode = BootManager.GetBootMode();
        if (bootMode == 2)
        {
            Console.Clear();
            Console.WriteLine(@"
   __ _            ____   _____ 
  / _| |          / __ \ / ____|
 | |_| | _____  _| |  | | (___  
 |  _| |/ _ \ \/ / |  | |\___ \ 
 | | | |  __/>  <| |__| |____) |
 |_| |_|\___/_/\_\\____/|_____/ 
                                
                                ");
            Console.WriteLine("Welcome to flexOS\nType help for command list\n");
            while (true)
            {
                Console.Write("root@flexOS> ");
                var command = Console.ReadLine();
                if (command == null) continue;
                string[] cmd = command.Split(" ");
                if (true)
                {
                    // Todo
                }
                else
                {
                    Console.WriteLine($"Unknown command: {cmd[0]}");
                    continue;
                }
            }
        }
    }
}