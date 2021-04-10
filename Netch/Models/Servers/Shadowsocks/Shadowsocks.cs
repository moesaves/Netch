namespace Netch.Models.Servers.Shadowsocks
{
    public class Shadowsocks : Server
    {
        public Shadowsocks()
        {
            this.Type = ServerType.Shadowsocks;
        }

        /// <summary>
        ///     密码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("passwd")]
        public string Passwd;

        /// <summary>
        ///     加密
        /// </summary>
        [Newtonsoft.Json.JsonProperty("method")]
        public string Method;

        /// <summary>
        ///     混淆
        /// </summary>
        [Newtonsoft.Json.JsonProperty("obfs")]
        public string OBFS;

        /// <summary>
        ///     混淆参数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("obfsparam")]
        public string OBFSParam;
    }
}
