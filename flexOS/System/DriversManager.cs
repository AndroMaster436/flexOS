namespace FlexOS.System;

using FlexOS.System.Drivers;

public static class DriversManager
{
    public static void Init()
    {
        Network.Init();
    }
}