using System;

namespace Netch.Models.Server
{
    public class Server
    {
        /// <summary>
        ///     类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        public ServerType Type;

        /// <summary>
        ///     备注
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        public string Remark;

        /// <summary>
        ///     群组
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group")]
        public string Group;

        /// <summary>
        ///     地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("host")]
        public string Host;

        /// <summary>
        ///     端口
        /// </summary>
        [Newtonsoft.Json.JsonProperty("port")]
        public ushort Port;

        /// <summary>
        ///     延迟
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public int Ping = -1;

        public override string ToString()
        {
            var name = "";
            switch (this.Type)
            {
                case ServerType.Socks:
                    name = "S5";
                    break;
                case ServerType.Shadowsocks:
                    name = "SS";
                    break;
                case ServerType.ShadowsocksR:
                    name = "SR";
                    break;
                case ServerType.Trojan:
                    name = "TR";
                    break;
                case ServerType.VLess:
                    name = "VL";
                    break;
                case ServerType.VMess:
                    name = "VM";
                    break;
                default:
                    name = "UN";
                    break;
            }

            return String.Format("[{0}] {1}", name, String.IsNullOrEmpty(this.Remark) ? $"{this.Host}:{this.Port}" : this.Remark);
        }
    }
}
