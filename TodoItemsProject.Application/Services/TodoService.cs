using System;
using System.Collections.Generic;
using System.Text;
using TodoItemsProject.Application.Interfaces;
using TodoItemsProject.Common.Services;
using TodoItemsProject.Domain.Models;

namespace TodoItemsProject.Application.Services
{
    public class TodoService : ITodoService
    {
        private readonly IDatabaseService context;
        private readonly UnitOfWork unitOfWork;
        public TodoService(IDatabaseService context)
        {
            this.context = context;
            unitOfWork = new UnitOfWork(this.context);
        }
        public IEnumerable<Todo> Get()
        {
            IEnumerable<Todo> todos = unitOfWork.TodoRepository.Get();
            foreach (Todo td in todos)
            {
                var place = unitOfWork.PlaceRepository.GetByID(td.PlaceId);
                td.Place = new Place{
                    Id = place.Id,
                    Title = place.Title,
                    Address = place.Address
                };
            }
            return todos;
        }

        public Todo GetById(int id)
        {
            return unitOfWork.TodoRepository.GetByID(id);
        }
        public void Add(Todo item)
        {
            unitOfWork.TodoRepository.Insert(item);
            unitOfWork.Save();
        }

        public void Delete(Todo item)
        {
            unitOfWork.TodoRepository.Delete(item);
            unitOfWork.Save();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Todo item)
        {
            unitOfWork.TodoRepository.Update(item);
            unitOfWork.Save();
        }
    }
}
