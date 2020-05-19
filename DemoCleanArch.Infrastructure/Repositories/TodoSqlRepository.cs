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

        public Task Add(Todo entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Todo entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Todo>> GetAll()
        {
            return await _context.Todo.ToListAsync();
        }

        public Task<Todo> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Todo entity)
        {
            throw new NotImplementedException();
        }
    }
}
