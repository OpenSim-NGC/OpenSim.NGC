using System;
using System.Collections.Generic;

#nullable disable

namespace OpenSim.Data.Models
{
    public partial class Landaccesslist
    {
        public string LandUuid { get; set; }
        public string AccessUuid { get; set; }
        public int? Flags { get; set; }
        public int Expires { get; set; }
    }
}
