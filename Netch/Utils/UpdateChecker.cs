using System.Collections.Generic;

namespace Netch.Utils
{
    public static class UpdateChecker
    {
        public static readonly string GitHub = "https://api.github.com";
        public static readonly string Owner = "NetchX";
        public static readonly string Repo = "Netch";

        /// <summary>
        ///     获取 GitHub Release 列表
        /// </summary>
        /// <returns></returns>
        public static List<Models.GitHub.Release> GetRelease()
        {
            var data = HTTP.GetString($"{GitHub}/repos/{Owner}/{Repo}/releases");

            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Models.GitHub.Release>>(data);
        }

        /// <summary>
        ///     检查是否有更新
        /// </summary>
        /// <returns></returns>
        public static bool HasUpdate()
        {
            var list = GetRelease();
            if (list.Count < 1)
            {
                return false;
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Draft)
                {
                    continue;
                }

                if (list[i].Unstable)
                {
                    continue;
                }

                if (!list[i].VerCode.Equals(Global.VerCode))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
