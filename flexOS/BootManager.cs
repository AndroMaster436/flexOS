namespace FlexOS;

public static class BootManager
{
    private static int _bootMode;

    public static void Init()
    {
        System.Console.Clear();
        System.Console.WriteLine("========== Boot Menu ==========");
        System.Console.WriteLine("Select boot mode:");
        System.Console.WriteLine("\n1. GUI");
        System.Console.WriteLine("2. System.Console\n");
        System.Console.WriteLine("================================");
        while (_bootMode == 0)
        {
            System.Console.Write("Boot:");
            var choose = System.Console.ReadKey().KeyChair;
            if (choose == '1') _bootMode = 2;
            else if (choose == '2') _bootMode = 2;
        }
    }

    public static int GetBootMenu()
    {
        return _bootMode;
    }
}