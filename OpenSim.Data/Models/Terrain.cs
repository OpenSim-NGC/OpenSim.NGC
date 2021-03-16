using System;
using System.Collections.Generic;

#nullable disable

namespace OpenSim.Data.Models
{
    public partial class Terrain
    {
        public string RegionUuid { get; set; }
        public int? Revision { get; set; }
        public byte[] Heightfield { get; set; }
    }
}
