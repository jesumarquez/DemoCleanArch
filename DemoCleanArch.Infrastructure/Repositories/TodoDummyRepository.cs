using DemoCleanArch.Domain.Entities;
using DemoCleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCleanArch.Infrastructure.Repositories
{
    public class TodoDummyRepository : ITodoRepository
    {
        List<Todo> _todos;
        public TodoDummyRepository()
        {
            _todos = Enumerable.Range(1, 10)
                .Select(x => new Todo { 
                    TodoId = x, 
                    Title = $"Title {x}" 
                }).ToList();
        }
        public async Task<IEnumerable<Todo>> GetAll()
        {
            await Task.Delay(10);
            return _todos;
        }
    }
}
