using System.Collections.Generic;

namespace Netch.Models.Mode.TunMode
{
    public class TunMode : Mode
    {
        public TunMode()
        {
            this.Type = ModeType.TunMode;
        }

        /// <summary>
        ///     实验特性
        /// </summary>
        [Newtonsoft.Json.JsonProperty("features")]
        public bool Experimental = false;

        /// <summary>
        ///     覆写全局 DNS 配置（为空不覆写）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("customdns")]
        public string OverrideDNS;

        /// <summary>
        ///     绕过列表（IP CIDR）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bypass")]
        public List<string> BypassList;

        /// <summary>
        ///     代理列表（IP CIDR）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("handle")]
        public List<string> HandleList;
    }
}
