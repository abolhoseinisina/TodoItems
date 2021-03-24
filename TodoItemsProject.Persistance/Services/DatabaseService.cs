using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using TodoItemsProject.Application.Interfaces;
using TodoItemsProject.Domain.Models;

namespace TodoItemsProject.Persistance.Services
{
    public class DatabaseService : DbContext, IDatabaseService
    {
        public DbSet<Todo> Todos { get; set; }

        public DbSet<Place> Places { get; set; }

        EntityEntry IDatabaseService.Entry<TEntity>(TEntity entityToUpdate)
        {
            return Entry(entityToUpdate);
        }

        void IDatabaseService.SaveChanges()
        {
            SaveChanges();
        }

    }
}
