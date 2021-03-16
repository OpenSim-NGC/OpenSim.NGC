using System;
using System.Collections.Generic;

#nullable disable

namespace OpenSim.Data.Models
{
    public partial class Friend
    {
        public string PrincipalId { get; set; }
        public string Friend1 { get; set; }
        public string Flags { get; set; }
        public string Offered { get; set; }
    }
}
