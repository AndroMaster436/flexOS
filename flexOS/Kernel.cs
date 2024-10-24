namespace FlexOS;

using System;
using Sys = Cosmos.System;
using System.Reflection;

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
                var command = Console.ReadLine();\
                if (command == null)
                {
                    Console.WriteLine("Bad command");
                    continue;
                }
                string[] cmd = command.Split(" ");
                var type = Type.GetType("FlexOS.Shell." + char.ToUpper(command[0]));
                if (type != null)
                {
                    var method = type.GetMethod("Execute", BindingFlags.Public | BindingFlags.Static);
                    method.Invoke(null, null);
                }
            }
        }
    }
}