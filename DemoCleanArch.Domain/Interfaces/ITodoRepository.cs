using DemoCleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoCleanArch.Domain.Interfaces
{
    public interface ITodoRepository: IBaseRepository<Todo>
    {
    }
}
