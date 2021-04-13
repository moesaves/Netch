using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netch.Models.Config
{
    public class Subscription
    {
        /// <summary>
        ///     启用 / 禁用
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enabled")]
        public bool Checked = true;

        /// <summary>
        ///     备注
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        public string Remark;

        /// <summary>
        ///     链接
        /// </summary>
        [Newtonsoft.Json.JsonProperty("link")]
        public string Link;
    }
}
