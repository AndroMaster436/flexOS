namespace FlexOS;

using System;

public static class BootManager
{
    private static int _bootMode;

    public static void Init()
    {
        Console.Clear();
        Console.WriteLine("========== Boot Menu ==========");
        Console.WriteLine("Select boot mode:");
        Console.WriteLine("\n1. GUI");
        Console.WriteLine("2. Console\n");
        Console.WriteLine("================================");
        while (_bootMode == 0)
        {
            Console.Write("Boot:");
            var choose = Console.ReadKey().KeyChair;
            if (choose == '1') _bootMode = 2;
            else if (choose == '2') _bootMode = 2;
        }
    }

    public static int GetBootMenu()
    {
        return _bootMode;
    }
}