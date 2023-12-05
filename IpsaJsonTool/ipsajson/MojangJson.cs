using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IpsaJsonTool.ipsajson
{
    public class MojangJson
    {
        // TODO

        public MojangJsonAssetIndex assetIndex { get; set; }
        public string assets { get; set; }
        public MojangJsonDownloads downloads { get; set; }
        public string id { get; set; }
        //public string libraries { get; set; } // TODO
        public string mainClass { get; set; }
        public string minecraftArguments { get; set; }
        public string type { get; set; }
    }

    public class MojangJsonDownloads
    {
        public MojangJsonDownloadsClient client { get; set; }
    }
    public class MojangJsonDownloadsClient
    {
        public int size { get; set; }
        public string url { get; set; }
    }

    public class MojangJsonAssetIndex
    {
        public string id { get; set; }
        public int size { get; set; }
        public int totalSize { get; set; }
        public string url { get; set; }
    }

}
