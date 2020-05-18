using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoCleanArch.Domain.Entities;
using DemoCleanArch.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoCleanArch.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private ITodoRepository _todoRepository;

        public TodoController(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public async Task<IActionResult> Get()
        {
            return Ok(await _todoRepository.GetAll());
        }
    }
}