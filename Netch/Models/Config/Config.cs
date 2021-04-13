using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netch.Models.Config
{
    public class Config
    {
        /// <summary>
        ///     端口 配置
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ports")]
        public Ports Ports = new Ports();

        /// <summary>
        ///     通用 配置
        /// </summary>
        [Newtonsoft.Json.JsonProperty("generic")]
        public Generic Generic = new Generic();

        /// <summary>
        ///     WinTUN 配置
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wintun")]
        public WinTUN WinTun = new WinTUN();

        /// <summary>
        ///     AioDNS 配置
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aiodns")]
        public AioDNS AioDNS = new AioDNS();

        /// <summary>
        ///     订阅链接
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subscriptions")]
        public List<Subscription> Subscriptions = new List<Subscription>();
    }
}
