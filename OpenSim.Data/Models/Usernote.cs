using System;
using System.Collections.Generic;

#nullable disable

namespace OpenSim.Data.Models
{
    public partial class Usernote
    {
        public string Useruuid { get; set; }
        public string Targetuuid { get; set; }
        public string Notes { get; set; }
    }
}
