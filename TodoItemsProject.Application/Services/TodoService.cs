using System;
using System.Collections.Generic;
using System.Text;
using TodoItemsProject.Application.Interfaces;
using TodoItemsProject.Domain.Models;

namespace TodoItemsProject.Application.Services
{
    public class TodoService : ITodoService
    {
        private IDatabaseService context;
        private UnitOfWork unitOfWork;
        public TodoService(IDatabaseService context)
        {
            this.context = context;
            unitOfWork = new UnitOfWork(this.context);
        }

        public void Add(Todo item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Todo item)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Todo item)
        {
            throw new NotImplementedException();
        }

        public void Get()
        {
            unitOfWork.TodoRepository.Get();
            //return unitOfWork.TodoRepository.Get();
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
