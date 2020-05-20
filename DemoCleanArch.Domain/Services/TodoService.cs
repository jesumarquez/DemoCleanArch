using AutoMapper;
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
        IMapper _mapper;
        public TodoService(ITodoRepository todoRepository, IMapper mapper)
        {
            _todoRepository = todoRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<TodoDto>> GetAll()
        {
            var todos = await _todoRepository.GetAll();
            return _mapper.Map<IEnumerable<TodoDto>>(todos);
        }
    }
}
