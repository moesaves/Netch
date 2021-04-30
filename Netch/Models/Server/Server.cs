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

        /// <summary>
        ///     测试延迟
        /// </summary>
        /// <returns></returns>
        public void TestPing() => this.Ping = Utils.Ping.Fetch(this);

        /// <summary>
        ///     获取备注
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string name = this.Type switch
            {
                ServerType.Socks => "S5",
                ServerType.Shadowsocks => "SS",
                ServerType.ShadowsocksR => "SR",
                ServerType.Trojan => "TR",
                ServerType.VLess => "VL",
                ServerType.VMess => "VM",
                _ => "UN",
            };

            return String.Format("[{0}] {1}", name, String.IsNullOrEmpty(this.Remark) ? $"{this.Host}:{this.Port}" : this.Remark);
        }
    }
}
