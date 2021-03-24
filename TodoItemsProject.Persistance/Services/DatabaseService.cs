using Microsoft.EntityFrameworkCore;
using TodoItemsProject.Application.Interfaces;
using TodoItemsProject.Domain.Models;

namespace TodoItemsProject.Persistance.Services
{
    public class DatabaseService : DbContext, IDatabaseService
    {
        public DbSet<Todo> Todos { get; set; }

        public DbSet<Place> Places { get; set; }
    }
}
