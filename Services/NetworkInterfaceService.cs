using System.Net.NetworkInformation;
using NetworkInfoApi.Models;
using System.Net.Sockets;

namespace NetworkInfoApi.Services
{
    public static class NetworkInterfaceService
    {
        public static List<NetworkInterfaceInfo> GetNetworkInfo()
        {
            var interfaces = NetworkInterface.GetAllNetworkInterfaces();
            var interfacesInfo = new List<NetworkInterfaceInfo>();
            foreach (var i in interfaces)
            {
                var ipAdresses = new List<string>();
                foreach (var ip in i.GetIPProperties().UnicastAddresses)
                    if (ip.Address.AddressFamily == AddressFamily.InterNetwork ||
                        ip.Address.AddressFamily == AddressFamily.InterNetworkV6)
                        ipAdresses.Add(ip.Address.ToString());


                interfacesInfo.Add(new NetworkInterfaceInfo
                {
                    Name = i.Name,
                    Description = i.Description,
                    Status = i.OperationalStatus.ToString(),
                    Addresses = ipAdresses
                });
            }
            return interfacesInfo;
        }
    }
}