using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoItemsProject.Application.Interfaces;
using TodoItemsProject.Domain.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoItemsProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaceController : ControllerBase
    {
        readonly IPlaceService placeService;
        public PlaceController(IPlaceService placeService)
        {
            this.placeService = placeService;
        }
        // GET: api/<PlacesController>
        [HttpGet]
        public IEnumerable<Place> Get()
        {
            return placeService.Get();
        }

        // GET api/<PlacesController>/5
        [HttpGet("{id}")]
        public Place Get(int id)
        {
            return placeService.GetById(id);
        }

        // POST api/<PlacesController>
        [HttpPost]
        public void Post(Place item)
        {
            placeService.Add(item);
        }

        // PUT api/<PlacesController>
        [HttpPut]
        public void Put(Place item)
        {
            placeService.Edit(item);
        }

        // DELETE api/<PlacesController>
        [HttpDelete]
        public void Delete(Place item)
        {
            placeService.Delete(item);
        }
    }
}
