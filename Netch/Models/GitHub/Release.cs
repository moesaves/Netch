using System.Collections.Generic;

namespace Netch.Models.GitHub
{
    /// <summary>
    ///      https://api.github.com/repos/{owner}/{repo}/releases
    /// </summary>
    public class Release
    {
        [Newtonsoft.Json.JsonProperty("html_url")]
        public string URL;

        [Newtonsoft.Json.JsonProperty("tag_name")]
        public string VerCode;

        [Newtonsoft.Json.JsonProperty("draft")]
        public bool Draft;

        [Newtonsoft.Json.JsonProperty("prerelease")]
        public bool Preview;

        [Newtonsoft.Json.JsonProperty("assets")]
        public List<Asset> Assets;
    }
}
