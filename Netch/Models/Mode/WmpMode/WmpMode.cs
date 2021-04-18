using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netch.Models.Mode.WmpMode
{
    public class WmpMode : Mode
    {
        public WmpMode()
        {
            this.Type = ModeType.WmpMode;
        }

        /// <summary>
        ///     监听地址
        /// </summary>
        public string ListenAddr;

        /// <summary>
        ///     监听端口
        /// </summary>
        public ushort ListenPort;

        /// <summary>
        ///     远端地址
        /// </summary>
        public string RemoteAddr;

        /// <summary>
        ///     远端端口
        /// </summary>
        public ushort RemotePort;
    }
}
