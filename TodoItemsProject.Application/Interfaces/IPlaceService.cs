using System;
using System.Collections.Generic;
using System.Text;
using TodoItemsProject.Domain.Models;

namespace TodoItemsProject.Application.Interfaces
{
    public interface IPlaceService
    {
        public IEnumerable<Place> Get();
        public Place GetById(int id);
        public void Add(Place item);
        public void Edit(Place item);
        public void Delete(Place item);
        public void DeleteById(int id);
    }
}
