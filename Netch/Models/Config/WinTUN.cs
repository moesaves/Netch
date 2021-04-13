using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netch.Models.Config
{
    public class WinTUN
    {
        /// <summary>
        ///     地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("network")]
        public string Network = "100.64.0.100/24";

        /// <summary>
        ///     网关
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gateway")]
        public string Gateway = "100.64.0.1";

        /// <summary>
        ///     网卡 DNS 地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dns")]
        public string DNS = "aiodns";

        /// <summary>
        ///     绕过 IP 地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bypass")]
        public List<string> BypassIPs = new List<string>();
    }
}
