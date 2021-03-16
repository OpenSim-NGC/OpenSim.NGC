using System;
using System.Collections.Generic;

#nullable disable

namespace OpenSim.Data.Models
{
    public partial class Gloebitsubscription
    {
        public string SubscriptionId { get; set; }
        public string ObjectId { get; set; }
        public string AppKey { get; set; }
        public string GlbApiUrl { get; set; }
        public bool Enabled { get; set; }
        public string ObjectName { get; set; }
        public string Description { get; set; }
    }
}
