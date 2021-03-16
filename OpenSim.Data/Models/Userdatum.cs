using System;
using System.Collections.Generic;

#nullable disable

namespace OpenSim.Data.Models
{
    public partial class Userdatum
    {
        public string UserId { get; set; }
        public string TagId { get; set; }
        public string DataKey { get; set; }
        public string DataVal { get; set; }
    }
}
