using System;
using System.Linq;
using System.Net.NetworkInformation;
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
        ///     使用名称获取适配器索引
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static ulong GetInterfaceIndexByDescription(string name)
        {
            var ada = NetworkInterface.GetAllNetworkInterfaces()
                .First(nic =>
                {
                    if (nic.Description.Equals(name))
                    {
                        return true;
                    }

                    return false;
                });

            int index = 0;
            if (ada.Supports(NetworkInterfaceComponent.IPv4))
            {
                index = ada.GetIPProperties().GetIPv4Properties().Index;
            }
            else if (ada.Supports(NetworkInterfaceComponent.IPv6))
            {
                index = ada.GetIPProperties().GetIPv6Properties().Index;
            }

            return Convert.ToUInt64(index);
        }
    }
}
