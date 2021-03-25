using System;

namespace TodoItemsProject.Domain.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
        public int PlaceId { get; set; }
        public Place Place { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime DueTime { get; set; }
    }
}
