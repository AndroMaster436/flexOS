using System.Net.Sockets;
using Cosmos.HAL;
using Cosmos.System.Network.Config;
using Cosmos.System.Network.IPv4;

namespace FlexOS
{
    public class DriversManager
    {
        private NetworkDevice networkDevice;

        public static void Init()
        {
            networkDevice = NetworkDevice.GetDeviceByName("eth0");
            IPConfig.Enable(networkDevice, new Address(192, 168, 1, 64), new Address(255, 255, 255, 0), new Address(192, 128, 1, 254));
        }
    }
}