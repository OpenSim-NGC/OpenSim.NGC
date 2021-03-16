using System;
using System.Collections.Generic;

#nullable disable

namespace OpenSim.Data.Models
{
    public partial class Agentpref
    {
        public string PrincipalId { get; set; }
        public string AccessPrefs { get; set; }
        public double HoverHeight { get; set; }
        public string Language { get; set; }
        public bool? LanguageIsPublic { get; set; }
        public int PermEveryone { get; set; }
        public int PermGroup { get; set; }
        public int PermNextOwner { get; set; }
    }
}
