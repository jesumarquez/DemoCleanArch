using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCleanArch.Domain.Interfaces
{
    public interface ICurrentUserService
    {
        string UserId { get; }
    }
}
