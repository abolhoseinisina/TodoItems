using System;
using System.Collections.Generic;
using System.Text;
using TodoItemsProject.Domain.Models;

namespace TodoItemsProject.Persistance.Services
{
    public class UnitOfWork
    {
        // Part 1
        private DatabaseService context = new DatabaseService();
        private GenericRepository<Todo> todoRepository;
        private GenericRepository<Place> placeRepository;

        public GenericRepository<Todo> TodoRepository
        {
            get
            {
                if (this.todoRepository == null)
                {
                    this.todoRepository = new GenericRepository<Todo>(context);
                }
                return todoRepository;
            }
        }

        public GenericRepository<Place> PlaceRepository
        {
            get
            {
                if (this.placeRepository == null)
                {
                    this.placeRepository = new GenericRepository<Place>(context);
                }
                return placeRepository;
            }
        }

        // Part 2
        public void Save()
        {
            context.SaveChanges();
        }

    }
}
