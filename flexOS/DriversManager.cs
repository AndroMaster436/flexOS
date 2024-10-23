using FlexOS.Drivers;

namespace FlexOS;

public static class DriversManager
{
    public static void Init()
    {
        Network.Init();
    }
}