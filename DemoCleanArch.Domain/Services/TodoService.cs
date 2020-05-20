using DemoCleanArch.Domain.Dtos;
using DemoCleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCleanArch.Domain.Services
{
    public class TodoService : ITodoService
    {
        ITodoRepository _todoRepository;
        public TodoService(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }
        public async Task<IEnumerable<TodoDto>> GetAll()
        {
            var todos = await _todoRepository.GetAll();
            return todos.Select(t => new TodoDto() { TodoId = t.TodoId, Title = t.Title });
        }
    }
}
