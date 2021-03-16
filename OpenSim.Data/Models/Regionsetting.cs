using System;
using System.Collections.Generic;

#nullable disable

namespace OpenSim.Data.Models
{
    public partial class Regionsetting
    {
        public string RegionUuid { get; set; }
        public int BlockTerraform { get; set; }
        public int BlockFly { get; set; }
        public int AllowDamage { get; set; }
        public int RestrictPushing { get; set; }
        public int AllowLandResell { get; set; }
        public int AllowLandJoinDivide { get; set; }
        public int BlockShowInSearch { get; set; }
        public int AgentLimit { get; set; }
        public double ObjectBonus { get; set; }
        public int Maturity { get; set; }
        public int DisableScripts { get; set; }
        public int DisableCollisions { get; set; }
        public int DisablePhysics { get; set; }
        public string TerrainTexture1 { get; set; }
        public string TerrainTexture2 { get; set; }
        public string TerrainTexture3 { get; set; }
        public string TerrainTexture4 { get; set; }
        public double Elevation1Nw { get; set; }
        public double Elevation2Nw { get; set; }
        public double Elevation1Ne { get; set; }
        public double Elevation2Ne { get; set; }
        public double Elevation1Se { get; set; }
        public double Elevation2Se { get; set; }
        public double Elevation1Sw { get; set; }
        public double Elevation2Sw { get; set; }
        public double WaterHeight { get; set; }
        public double TerrainRaiseLimit { get; set; }
        public double TerrainLowerLimit { get; set; }
        public int UseEstateSun { get; set; }
        public int FixedSun { get; set; }
        public double SunPosition { get; set; }
        public string Covenant { get; set; }
        public byte Sandbox { get; set; }
        public double Sunvectorx { get; set; }
        public double Sunvectory { get; set; }
        public double Sunvectorz { get; set; }
        public string LoadedCreationId { get; set; }
        public int LoadedCreationDatetime { get; set; }
        public string MapTileId { get; set; }
        public string TelehubObject { get; set; }
        public string ParcelTileId { get; set; }
        public int CovenantDatetime { get; set; }
        public byte BlockSearch { get; set; }
        public byte Casino { get; set; }
        public string CacheId { get; set; }
    }
}
