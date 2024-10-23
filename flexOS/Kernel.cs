namespace FlexOS;

using System;
using System.Text;
using Sys = Cosmos.System;
using FlexOS.Shell;

public class Kernel : Sys.Kernel
{
    protected override void BeforeRun()
    {
        BootManager.Init();
        DriversManager.Init();
        CommandManager.Init();
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
                string[] cmd = command.Split(" ");
                CommandManager.ExecuteCommand(cmd);
            }
        }
    }
}