using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Json;
using TodoItemsProject.Application.Interfaces;
using TodoItemsProject.Domain.Models;

namespace TodoItemsProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        readonly ITodoService todoService;
        public TodoController(ITodoService todoService)
        {
            this.todoService = todoService;
        }
        [HttpGet]
        public IEnumerable<object> Get()
        {
            var r = todoService.Get();
            return todoService.Get();
        }
        [HttpGet("{id}")]
        public Todo Get(int id)
        {
            return todoService.GetById(id);
        }
        [HttpPut]
        public void Put(Todo item)
        {
            todoService.Edit(item);
        }
        [HttpPost]
        public void Post(Todo item)
        {
            todoService.Add(item);
        }
        [HttpDelete]
        public void Delete(Todo item)
        {
            todoService.Delete(item);
        }
    }
}
