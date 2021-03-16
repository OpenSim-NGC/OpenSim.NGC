using System;
using System.Collections.Generic;

#nullable disable

namespace OpenSim.Data.Models
{
    public partial class OsGroupsMembership
    {
        public string GroupId { get; set; }
        public string PrincipalId { get; set; }
        public string SelectedRoleId { get; set; }
        public int Contribution { get; set; }
        public int ListInProfile { get; set; }
        public int AcceptNotices { get; set; }
        public string AccessToken { get; set; }
    }
}
