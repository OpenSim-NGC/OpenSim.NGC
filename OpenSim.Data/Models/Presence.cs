using System;
using System.Collections.Generic;

#nullable disable

namespace OpenSim.Data.Models
{
    public partial class Presence
    {
        public string UserId { get; set; }
        public string RegionId { get; set; }
        public string SessionId { get; set; }
        public string SecureSessionId { get; set; }
    }
}
