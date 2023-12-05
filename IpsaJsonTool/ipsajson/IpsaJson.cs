using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IpsaJsonTool.ipsajson
{
    // IpsaJson v1.0
    // by DEJVOSS Productions
    // use for Codex-Ipsa Launcher

    public class IpsaJson
    {
        public string game { get; set; }
        public string version { get; set; }
        public string url { get; set; }
        public int size { get; set; }
        public int java { get; set; }
        public string cmdBef { get; set; }
        public string cmdAft { get; set; }
        public string defRes { get; set; }
        public bool srvJoin { get; set; }
        public IpsaJsonAssets assets { get; set; }
        public string logging { get; set; }
        public string classpath { get; set; }
        public IpsaJsonSupplement[] supplement { get; set; }
        public IpsaJsonLibraries[] libraries { get; set; }
    }

    public class IpsaJsonAssets
    {
        public string name { get; set; }
        public string url { get; set; }
        public int size { get; set; }
        public int fileSize { get; set; }
    }

    public class IpsaJsonLibraries
    {
        public string name { get; set; }
        public string url { get; set; }
        public int size { get; set; }
        public bool extract { get; set; }
    }

    public class IpsaJsonSupplement
    {
        public string url { get; set; }
        public string path { get; set; }
        public int name { get; set; }
        public bool renew { get; set; }
    }
}
