using System;
using System.Collections.Generic;

#nullable disable

namespace OpenSim.Data.Models
{
    public partial class SpawnPoint
    {
        public string RegionId { get; set; }
        public float Yaw { get; set; }
        public float Pitch { get; set; }
        public float Distance { get; set; }
    }
}
