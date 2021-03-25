using System;
using System.Collections.Generic;
using System.Text;
using TodoItemsProject.Domain.Models;

namespace TodoItemsProject.Application.Interfaces
{
    public interface ITodoService
    {
        public IEnumerable<Todo> Get();
        public Todo GetById(int id);
        public void Add(Todo item);
        public void Edit(Todo item);
        public void Delete(Todo item);
        public void DeleteById(int id);
    }
}
