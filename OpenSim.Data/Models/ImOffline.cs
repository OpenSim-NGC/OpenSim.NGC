using System;
using System.Collections.Generic;

#nullable disable

namespace OpenSim.Data.Models
{
    public partial class ImOffline
    {
        public int Id { get; set; }
        public string PrincipalId { get; set; }
        public string FromId { get; set; }
        public string Message { get; set; }
    }
}
