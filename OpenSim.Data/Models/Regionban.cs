using System;
using System.Collections.Generic;

#nullable disable

namespace OpenSim.Data.Models
{
    public partial class Regionban
    {
        public string RegionUuid { get; set; }
        public string BannedUuid { get; set; }
        public string BannedIp { get; set; }
        public string BannedIpHostMask { get; set; }
    }
}
