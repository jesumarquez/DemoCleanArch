using DemoCleanArch.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoCleanArch.Domain.Interfaces
{
    public interface ITodoService
    {
        Task<IEnumerable<TodoDto>> GetAll();
    }
}
