using System;
using System.Collections.Generic;

#nullable disable

namespace OpenSim.Data.Models
{
    public partial class Auth
    {
        public string Uuid { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string WebLoginKey { get; set; }
        public string AccountType { get; set; }
    }
}
