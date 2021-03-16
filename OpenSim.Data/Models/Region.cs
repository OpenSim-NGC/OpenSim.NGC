using System;
using System.Collections.Generic;

#nullable disable

namespace OpenSim.Data.Models
{
    public partial class Region
    {
        public string Uuid { get; set; }
        public long RegionHandle { get; set; }
        public string RegionName { get; set; }
        public string RegionRecvKey { get; set; }
        public string RegionSendKey { get; set; }
        public string RegionSecret { get; set; }
        public string RegionDataUri { get; set; }
        public string ServerIp { get; set; }
        public int? ServerPort { get; set; }
        public string ServerUri { get; set; }
        public int? LocX { get; set; }
        public int? LocY { get; set; }
        public int? LocZ { get; set; }
        public long? EastOverrideHandle { get; set; }
        public long? WestOverrideHandle { get; set; }
        public long? SouthOverrideHandle { get; set; }
        public long? NorthOverrideHandle { get; set; }
        public string RegionAssetUri { get; set; }
        public string RegionAssetRecvKey { get; set; }
        public string RegionAssetSendKey { get; set; }
        public string RegionUserUri { get; set; }
        public string RegionUserRecvKey { get; set; }
        public string RegionUserSendKey { get; set; }
        public string RegionMapTexture { get; set; }
        public int? ServerHttpPort { get; set; }
        public int? ServerRemotingPort { get; set; }
        public string OwnerUuid { get; set; }
        public string OriginUuid { get; set; }
        public int? Access { get; set; }
        public string ScopeId { get; set; }
        public int SizeX { get; set; }
        public int SizeY { get; set; }
        public int Flags { get; set; }
        public int LastSeen { get; set; }
        public string PrincipalId { get; set; }
        public string Token { get; set; }
        public string ParcelMapTexture { get; set; }
    }
}
