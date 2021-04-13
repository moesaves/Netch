using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netch.Models.Config
{
    public class Generic
    {
        /// <summary>
        ///     将域名转换为 IP 地址
        /// </summary>
        public bool ResolveHostname = true;

        /// <summary>
        ///     使用 ICMP 测试延迟
        /// </summary>
        public bool ICMPing = false;

        /// <summary>
        ///     STUN
        /// </summary>
        public string STUN = "stun.qq.com";
    }
}
