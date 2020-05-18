using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCleanArch.Domain.Common
{
    public abstract class AuditEntity
    {
        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
