using System;
using System.Collections.Generic;

#nullable disable

namespace OpenSim.Data.Models
{
    public partial class Regionwindlight
    {
        public string RegionId { get; set; }
        public float BigWaveDirectionX { get; set; }
        public float BigWaveDirectionY { get; set; }
        public float LittleWaveDirectionX { get; set; }
        public float LittleWaveDirectionY { get; set; }
        public string NormalMapTexture { get; set; }
        public int MaxAltitude { get; set; }
        public float CloudScrollX { get; set; }
        public byte CloudScrollXLock { get; set; }
        public float CloudScrollY { get; set; }
        public byte CloudScrollYLock { get; set; }
        public byte DrawClassicClouds { get; set; }
    }
}
