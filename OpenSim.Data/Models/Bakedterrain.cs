using System;
using System.Collections.Generic;

#nullable disable

namespace OpenSim.Data.Models
{
    public partial class Bakedterrain
    {
        public string RegionUuid { get; set; }
        public int? Revision { get; set; }
        public byte[] Heightfield { get; set; }
    }
}
