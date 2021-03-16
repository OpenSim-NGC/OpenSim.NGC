using System;
using System.Collections.Generic;

#nullable disable

namespace OpenSim.Data.Models
{
    public partial class Gloebituser
    {
        public string AppKey { get; set; }
        public string PrincipalId { get; set; }
        public string GloebitId { get; set; }
        public string GloebitToken { get; set; }
        public string LastSessionId { get; set; }
    }
}
