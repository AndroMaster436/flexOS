namespace FlexOS;

using FlexOS.Drivers;

public static class DriversManager
{
    public static void Init()
    {
        Network.Init();
    }
}