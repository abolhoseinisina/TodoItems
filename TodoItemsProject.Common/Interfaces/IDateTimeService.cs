using System;
using System.Collections.Generic;
using System.Text;

namespace TodoItemsProject.Common.Interfaces
{
    public interface IDateTimeService
    {
        public DateTime Now { get; }
    }
}
