using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCleanArch.Domain.Entities
{
    public class Todo: AuditEntity
    {
        public int TodoId { get; set; }
        public string Title { get; set; }
    }
}
