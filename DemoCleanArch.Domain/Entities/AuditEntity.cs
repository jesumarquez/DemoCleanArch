using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCleanArch.Domain.Entities
{
    public class AuditEntity
    {
        public DateTime CreationTime { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}
