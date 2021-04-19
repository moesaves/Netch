using System.Runtime.InteropServices;

namespace Netch.Controllers.Others
{
    public class DNSController : Interface.IController
    {
        private class NativeMethods
        {
            public enum NameList : int
            {
                TYPE_REST,
                TYPE_ADDR,
                TYPE_LIST,
                TYPE_CDNS,
                TYPE_ODNS
            }

            [DllImport("aiodns.bin", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool aiodns_dial(NameList name, string value);

            [DllImport("aiodns.bin", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool aiodns_init();

            [DllImport("aiodns.bin", CallingConvention = CallingConvention.Cdecl)]
            public static extern void aiodns_free();
        }

        public bool Create(Models.Server.Server s, Models.Mode.Mode m)
        {
            NativeMethods.aiodns_dial(NativeMethods.NameList.TYPE_REST, "");
            NativeMethods.aiodns_dial(NativeMethods.NameList.TYPE_ADDR, ":53");
            NativeMethods.aiodns_dial(NativeMethods.NameList.TYPE_LIST, "bin\\aiodns.conf");
            NativeMethods.aiodns_dial(NativeMethods.NameList.TYPE_CDNS, Global.Config.AioDNS.ChinaDNS);
            NativeMethods.aiodns_dial(NativeMethods.NameList.TYPE_ODNS, Global.Config.AioDNS.OtherDNS);

            return NativeMethods.aiodns_init();
        }

        public bool Delete()
        {
            NativeMethods.aiodns_free();

            return true;
        }
    }
}
