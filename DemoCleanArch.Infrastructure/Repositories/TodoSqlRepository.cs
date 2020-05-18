using DemoCleanArch.Domain.Entities;
using DemoCleanArch.Domain.Interfaces;
using DemoCleanArch.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace DemoCleanArch.Infrastructure.Repositories
{
    public class TodoSqlRepository : ITodoRepository
    {
        readonly TodoContext _context;

        public TodoSqlRepository(TodoContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Todo>> GetAll()
        {
            return await _context.Todo.ToListAsync();
        }
    }
}
