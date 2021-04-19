using System.Collections.Generic;

namespace Netch.Models.Mode.ShareMode
{
    public class ShareMode : Mode
    {
        public ShareMode()
        {
            this.Type = ModeType.ShareMode;
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
    }
}
