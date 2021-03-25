using System;
using System.Collections.Generic;
using System.Text;
using TodoItemsProject.Application.Interfaces;
using TodoItemsProject.Domain.Models;

namespace TodoItemsProject.Application.Services
{
    public class PlaceService : IPlaceService
    {
        readonly private IDatabaseService context;
        readonly private UnitOfWork unitOfWork;
        public PlaceService(IDatabaseService context)
        {
            this.context = context;
            unitOfWork = new UnitOfWork(this.context);
        }
        public void Add(Place item)
        {
            unitOfWork.PlaceRepository.Insert(item);
            unitOfWork.Save();
        }

        public void Delete(Place item)
        {
            unitOfWork.PlaceRepository.Delete(item);
            unitOfWork.Save();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Place item)
        {
            unitOfWork.PlaceRepository.Update(item);
            unitOfWork.Save();
        }

        public IEnumerable<Place> Get()
        {
            return unitOfWork.PlaceRepository.Get();
        }

        public Place GetById(int id)
        {
            return unitOfWork.PlaceRepository.GetByID(id);
        }
    }
}
