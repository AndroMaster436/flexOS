using System;
using Sys = Cosmos.System;
using Cosmos.System.Network.IPv4.UDP.DNS;
using Cosmos.System.Network.IPv4;
using System.Runtime.InteropServices;
using System.Net.Sockets;
using System.Text;

namespace FlexOS
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            DriversManager.Init();
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
        }

        protected override void Run()
        {
            while (true)
            {
                Console.Write("root@flexOS> ");
                var command = Console.ReadLine();
                string[] cmd = command.Split(" ").ToLower();
                switch (cmd[0])
                {
                    case "ping":
                        if (cmd.Length == 1) Console.WriteLine("Usage: ping [SITE]");
                        else
                        {
                            using (var dnsClient = new DnsClient())
                            {
                                dnsClient.Connect(new Address(8, 8, 8, 8));
                                dnsClient.SendAsk(cmd[1]);
                                Console.WriteLine($"Pinged! IP: {dnsClient.Receive()}");
                            }
                        }
                        break;
                    default:
                        Console.WriteLine($"Incorrect command: {cmd}");
                        break;
                }
            }
        }
    }
}