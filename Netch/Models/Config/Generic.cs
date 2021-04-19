namespace Netch.Models.Config
{
    public class Generic
    {
        /// <summary>
        ///     检查 Unstable 更新
        /// </summary>
        public bool Unstable = false;

        /// <summary>
        ///     使用 ICMP 测试延迟
        /// </summary>
        public bool ICMPing = true;

        /// <summary>
        ///     将域名转换为 IP 地址
        /// </summary>
        public bool ResolveHostname = true;

        /// <summary>
        ///     STUN
        /// </summary>
        public string STUN = "stun.qq.com";
    }
}
