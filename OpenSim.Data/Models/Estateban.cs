using System;
using System.Collections.Generic;

#nullable disable

namespace OpenSim.Data.Models
{
    public partial class Estateban
    {
        public int EstateId { get; set; }
        public string BannedUuid { get; set; }
        public string BannedIp { get; set; }
        public string BannedIpHostMask { get; set; }
        public string BannedNameMask { get; set; }
        public string BanningUuid { get; set; }
        public int BanTime { get; set; }
    }
}
