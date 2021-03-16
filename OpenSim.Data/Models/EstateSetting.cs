using System;
using System.Collections.Generic;

#nullable disable

namespace OpenSim.Data.Models
{
    public partial class EstateSetting
    {
        public int EstateId { get; set; }
        public string EstateName { get; set; }
        public byte AbuseEmailToEstateOwner { get; set; }
        public byte DenyAnonymous { get; set; }
        public byte ResetHomeOnTeleport { get; set; }
        public byte FixedSun { get; set; }
        public byte DenyTransacted { get; set; }
        public byte BlockDwell { get; set; }
        public byte DenyIdentified { get; set; }
        public byte AllowVoice { get; set; }
        public byte UseGlobalTime { get; set; }
        public int PricePerMeter { get; set; }
        public byte TaxFree { get; set; }
        public byte AllowDirectTeleport { get; set; }
        public int RedirectGridX { get; set; }
        public int RedirectGridY { get; set; }
        public int ParentEstateId { get; set; }
        public double SunPosition { get; set; }
        public byte EstateSkipScripts { get; set; }
        public float BillableFactor { get; set; }
        public byte PublicAccess { get; set; }
        public string AbuseEmail { get; set; }
        public string EstateOwner { get; set; }
        public byte DenyMinors { get; set; }
        public byte AllowLandmark { get; set; }
        public byte AllowParcelChanges { get; set; }
        public byte AllowSetHome { get; set; }
        public byte AllowEnviromentOverride { get; set; }
    }
}
