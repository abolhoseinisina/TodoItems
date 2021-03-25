using System.Collections.Generic;

namespace TodoItemsProject.Domain.Models
{
    public class Place
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public List<Todo> Todos { get; set; }
    }
}
