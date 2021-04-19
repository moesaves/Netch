using System.Collections.Generic;

namespace Netch.Models.Config
{
    public class Config
    {
        /// <summary>
        ///     配置 版本
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verCode")]
        public int VerCode = 1;

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
        ///     V2Ray 配置
        /// </summary>
        [Newtonsoft.Json.JsonProperty("v2ray")]
        public V2Ray V2Ray = new V2Ray();

        /// <summary>
        ///     订阅链接
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subscriptions")]
        public List<Subscription> Subscriptions = new List<Subscription>();
    }
}
