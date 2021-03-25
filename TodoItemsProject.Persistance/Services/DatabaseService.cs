using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using TodoItemsProject.Application.Interfaces;
using TodoItemsProject.Domain.Models;

namespace TodoItemsProject.Persistance.Services
{
    public class DatabaseService : DbContext, IDatabaseService
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
           => optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TodoItemsProjectDB;Trusted_Connection=True;MultipleActiveResultSets=true");

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
