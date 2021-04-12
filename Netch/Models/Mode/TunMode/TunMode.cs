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
        public bool Experimental;

        /// <summary>
        ///     覆写全局 DNS 配置（为空不覆写）
        /// </summary>
        public string OverrideDNS;

        /// <summary>
        ///     绕过列表（IP CIDR）
        /// </summary>
        public List<string> BypassList;

        /// <summary>
        ///     代理列表（IP CIDR）
        /// </summary>
        public List<string> HandleList;
    }
}
