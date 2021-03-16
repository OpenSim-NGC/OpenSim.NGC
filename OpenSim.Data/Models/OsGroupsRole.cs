using System;
using System.Collections.Generic;

#nullable disable

namespace OpenSim.Data.Models
{
    public partial class OsGroupsRole
    {
        public string GroupId { get; set; }
        public string RoleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public long Powers { get; set; }
    }
}
