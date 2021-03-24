using System;
using System.Collections.Generic;
using System.Text;

namespace TodoItemsProject.Domain.Models
{
    class Place
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public IEnumerable<Todo> Todos { get; set; }
    }
}
