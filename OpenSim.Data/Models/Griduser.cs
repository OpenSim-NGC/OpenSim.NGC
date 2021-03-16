using System;
using System.Collections.Generic;

#nullable disable

namespace OpenSim.Data.Models
{
    public partial class Griduser
    {
        public string UserId { get; set; }
        public string HomeRegionId { get; set; }
        public string HomePosition { get; set; }
        public string HomeLookAt { get; set; }
        public string LastRegionId { get; set; }
        public string LastPosition { get; set; }
        public string LastLookAt { get; set; }
        public string Online { get; set; }
        public string Login { get; set; }
        public string Logout { get; set; }
        public string DisplayName { get; set; }
        public string NameCached { get; set; }
    }
}
