using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace TodoItemsProject.Application.Interfaces
{
    public interface IDatabaseService
    {
        void SaveChanges();
        EntityEntry Entry<TEntity>(TEntity entityToUpdate) where TEntity : class;
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}
