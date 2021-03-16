using System;
using System.Collections.Generic;

#nullable disable

namespace OpenSim.Data.Models
{
    public partial class Asset
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public byte AssetType { get; set; }
        public bool Local { get; set; }
        public bool Temporary { get; set; }
        public byte[] Data { get; set; }
        public string Id { get; set; }
        public int? CreateTime { get; set; }
        public int? AccessTime { get; set; }
        public int AssetFlags { get; set; }
        public string CreatorId { get; set; }
    }
}
