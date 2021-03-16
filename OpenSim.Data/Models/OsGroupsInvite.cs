using System;
using System.Collections.Generic;

#nullable disable

namespace OpenSim.Data.Models
{
    public partial class OsGroupsInvite
    {
        public string InviteId { get; set; }
        public string GroupId { get; set; }
        public string RoleId { get; set; }
        public string PrincipalId { get; set; }
    }
}
