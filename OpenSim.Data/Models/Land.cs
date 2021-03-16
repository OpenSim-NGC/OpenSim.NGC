using System;
using System.Collections.Generic;

#nullable disable

namespace OpenSim.Data.Models
{
    public partial class Land
    {
        public string Uuid { get; set; }
        public string RegionUuid { get; set; }
        public int? LocalLandId { get; set; }
        public byte[] Bitmap { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OwnerUuid { get; set; }
        public int? IsGroupOwned { get; set; }
        public int? Area { get; set; }
        public int? AuctionId { get; set; }
        public int? Category { get; set; }
        public int? ClaimDate { get; set; }
        public int? ClaimPrice { get; set; }
        public string GroupUuid { get; set; }
        public int? SalePrice { get; set; }
        public int? LandStatus { get; set; }
        public int? LandFlags { get; set; }
        public int? LandingType { get; set; }
        public int? MediaAutoScale { get; set; }
        public string MediaTextureUuid { get; set; }
        public string MediaUrl { get; set; }
        public string MusicUrl { get; set; }
        public float? PassHours { get; set; }
        public int? PassPrice { get; set; }
        public string SnapshotUuid { get; set; }
        public float? UserLocationX { get; set; }
        public float? UserLocationY { get; set; }
        public float? UserLocationZ { get; set; }
        public float? UserLookAtX { get; set; }
        public float? UserLookAtY { get; set; }
        public float? UserLookAtZ { get; set; }
        public string AuthbuyerId { get; set; }
        public int OtherCleanTime { get; set; }
        public int Dwell { get; set; }
        public string MediaType { get; set; }
        public string MediaDescription { get; set; }
        public string MediaSize { get; set; }
        public bool MediaLoop { get; set; }
        public bool ObscureMusic { get; set; }
        public bool ObscureMedia { get; set; }
        public byte SeeAvs { get; set; }
        public byte AnyAvsounds { get; set; }
        public byte GroupAvsounds { get; set; }
        public string Environment { get; set; }
    }
}
