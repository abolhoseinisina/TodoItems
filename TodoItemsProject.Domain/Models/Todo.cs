using System;
using System.Collections.Generic;
using System.Text;

namespace TodoItemsProject.Domain.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
        public Place Location { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime DueTime { get; set; }
    }
}
