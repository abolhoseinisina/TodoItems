using System;
using System.Collections.Generic;
using System.Text;
using TodoItemsProject.Common.Interfaces;

namespace TodoItemsProject.Common.Services
{
    public class DateTimeService : IDateTimeService
    {
        public static DateTime Now { get => DateTime.Now; }
    }
}
