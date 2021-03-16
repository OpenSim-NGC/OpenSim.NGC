using System;
using System.Collections.Generic;

#nullable disable

namespace OpenSim.Data.Models
{
    public partial class Fsasset
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public string Hash { get; set; }
        public int CreateTime { get; set; }
        public int AccessTime { get; set; }
        public int AssetFlags { get; set; }
    }
}
