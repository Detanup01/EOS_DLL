using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;

namespace EOS_SDK._Networking
{
    public static class AddressHelper
    {
        public static uint ConvertFromIpAddressToInteger(string ipAddress)
        {
            var address = IPAddress.Parse(ipAddress);
            byte[] bytes = address.GetAddressBytes();

            // flip big-endian(network order) to little-endian
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            return BitConverter.ToUInt32(bytes, 0);
        }

        public static string ConvertFromIntegerToIpAddress(uint ipAddress)
        {
            byte[] bytes = BitConverter.GetBytes(ipAddress);

            // flip little-endian to big-endian(network order)
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            return new IPAddress(bytes).ToString();
        }

        /// <summary>
        /// Only Returns IPV4!
        /// </summary>
        /// <returns></returns>
        public static List<(IPAddress ip, IPAddress mask)> GetIpMasks()
        {
            List<(IPAddress ip, IPAddress mask)> values = new();
            foreach (var adapter in NetworkInterface.GetAllNetworkInterfaces())
            {
                IPInterfaceProperties ipProperties = adapter.GetIPProperties();
                if (!adapter.GetIPProperties().MulticastAddresses.Any())
                    continue; // most of VPN adapters will be skipped
                if (!adapter.SupportsMulticast)
                    continue; // multicast is meaningless for this type of connection
                if (OperationalStatus.Up != adapter.OperationalStatus)
                    continue; // this adapter is off or not connected
                foreach (var item in ipProperties.UnicastAddresses)
                {
                    if (item.Address.AddressFamily != AddressFamily.InterNetwork)
                        continue;
                    values.Add((item.Address, item.IPv4Mask));
                }
            }
            return values;
        }

        public static List<IPAddress> GetIPs()
        {
            List<IPAddress> values = new();
            foreach (var adapter in NetworkInterface.GetAllNetworkInterfaces())
            {
                IPInterfaceProperties ipProperties = adapter.GetIPProperties();
                if (!adapter.GetIPProperties().MulticastAddresses.Any())
                    continue; // most of VPN adapters will be skipped
                if (!adapter.SupportsMulticast)
                    continue; // multicast is meaningless for this type of connection
                if (OperationalStatus.Up != adapter.OperationalStatus)
                    continue; // this adapter is off or not connected
                foreach (var item in ipProperties.UnicastAddresses)
                {
                    if (item.Address.AddressFamily != AddressFamily.InterNetwork)
                        continue;
                    values.Add(item.Address);
                }
            }
            return values;
        }
    }
}
