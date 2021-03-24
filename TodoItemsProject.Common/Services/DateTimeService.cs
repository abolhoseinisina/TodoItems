using System;
using System.Collections.Generic;
using System.Text;
using TodoItemsProject.Common.Interfaces;

namespace TodoItemsProject.Common.Services
{
    class DateTimeService : IDateTimeService
    {
        public DateTime Now { get => DateTime.Now; }
    }
}
