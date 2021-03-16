using System;
using System.Collections.Generic;

#nullable disable

namespace OpenSim.Data.Models
{
    public partial class Mutelist
    {
        public string AgentId { get; set; }
        public string MuteId { get; set; }
        public string MuteName { get; set; }
        public int MuteType { get; set; }
        public int MuteFlags { get; set; }
        public int Stamp { get; set; }
    }
}
