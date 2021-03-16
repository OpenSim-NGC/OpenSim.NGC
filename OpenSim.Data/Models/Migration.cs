using System;
using System.Collections.Generic;

#nullable disable

namespace OpenSim.Data.Models
{
    public partial class Migration
    {
        public string Name { get; set; }
        public int? Version { get; set; }
    }
}
