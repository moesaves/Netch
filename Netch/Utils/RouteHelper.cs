using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace Netch.Utils
{
    public static class RouteHelper
    {
        /// <summary>
        ///     将 Luid 转换为 Index 索引
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [DllImport("RouteHelper.bin", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong ConvertLuidToIndex(ulong id);

        /// <summary>
        ///     绑定 IP 地址（Windows XP）
        /// </summary>
        /// <param name="address"></param>
        /// <param name="netmask"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        [DllImport("RouteHelper.bin", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool CreateIPv4(string address, string netmask, ulong index);

        /// <summary>
        ///     绑定 IP 地址
        /// </summary>
        /// <param name="inet"></param>
        /// <param name="address"></param>
        /// <param name="cidr"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        [DllImport("RouteHelper.bin", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool CreateUnicastIP(AddressFamily inet, string address, byte cidr, ulong index);

        /// <summary>
        ///     创建路由
        /// </summary>
        /// <param name="inet"></param>
        /// <param name="address"></param>
        /// <param name="cidr"></param>
        /// <param name="gateway"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        [DllImport("RouteHelper.bin", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool CreateRoute(AddressFamily inet, string address, byte cidr, string gateway, ulong index);

        /// <summary>
        ///     删除路由
        /// </summary>
        /// <param name="inet"></param>
        /// <param name="address"></param>
        /// <param name="cidr"></param>
        /// <param name="gateway"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        [DllImport("RouteHelper.bin", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool DeleteRoute(AddressFamily inet, string address, byte cidr, string gateway, ulong index);

        /// <summary>
        ///     获取 IP 地址
        /// </summary>
        /// <returns></returns>
        public static IPAddress GetBestAddr()
        {
            try
            {
                using (var client = new Socket(SocketType.Stream, ProtocolType.Tcp))
                {
                    var tk = client.ConnectAsync(new IPEndPoint(IPAddress.Parse("114.114.114.114"), 53));
                    if (!tk.Wait(1000))
                    {
                        return IPAddress.Any;
                    }

                    return (client.LocalEndPoint as IPEndPoint).Address;
                }
            }
            catch (Exception e)
            {
                Global.Logger.Warning(e.ToString());

                return IPAddress.Any;
            }
        }

        /// <summary>
        ///     获取 IP 地址
        /// </summary>
        /// <returns></returns>
        public static IPAddress GetBestGate()
        {
            if (Vanara.PInvoke.Win32Error.NO_ERROR != Vanara.PInvoke.IpHlpApi.GetBestRoute(BitConverter.ToUInt32(IPAddress.Parse("114.114.114.114").GetAddressBytes(), 0), 0, out var route))
            {
                return IPAddress.Any;
            }

            return new IPAddress(route.dwForwardNextHop.S_un_b);
        }
    }
}
