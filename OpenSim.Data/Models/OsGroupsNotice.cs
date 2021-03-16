using System;
using System.Collections.Generic;

#nullable disable

namespace OpenSim.Data.Models
{
    public partial class OsGroupsNotice
    {
        public string GroupId { get; set; }
        public string NoticeId { get; set; }
        public int Tmstamp { get; set; }
        public string FromName { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public int HasAttachment { get; set; }
        public int AttachmentType { get; set; }
        public string AttachmentName { get; set; }
        public string AttachmentItemId { get; set; }
        public string AttachmentOwnerId { get; set; }
    }
}
