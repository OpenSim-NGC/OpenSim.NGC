using System;
using System.Collections.Generic;

#nullable disable

namespace OpenSim.Data.Models
{
    public partial class Useraccount
    {
        public string PrincipalId { get; set; }
        public string ScopeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ServiceUrls { get; set; }
        public int? Created { get; set; }
        public int UserLevel { get; set; }
        public int UserFlags { get; set; }
        public string UserTitle { get; set; }
        public int Active { get; set; }
        public string DisplayName { get; set; }
        public int? NameChanged { get; set; }
    }
}
