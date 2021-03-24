using System;
using System.Collections.Generic;
using System.Text;
using TodoItemsProject.Application.Interfaces;
using TodoItemsProject.Domain.Models;

namespace TodoItemsProject.Application.Services
{
    class UnitOfWork
    {
        private IDatabaseService context;
        private GenericRepository<Todo> todoRepository;
        private GenericRepository<Place> placeRepository;

        public UnitOfWork(IDatabaseService context)
        {
            this.context = context;
        }

        public GenericRepository<Todo> TodoRepository
        {
            get
            {
                if (todoRepository == null)
                {
                    todoRepository = new GenericRepository<Todo>(context);
                }
                return todoRepository;
            }
        }

        public GenericRepository<Place> PlaceRepository
        {
            get
            {
                if (placeRepository == null)
                {
                    placeRepository = new GenericRepository<Place>(context);
                }
                return placeRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
