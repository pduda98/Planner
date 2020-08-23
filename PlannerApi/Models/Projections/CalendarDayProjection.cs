using System;
using System.Collections.Generic;

namespace PlannerApi.Models.Projections
{
    public class CalendarDay
    {
        public DateTime Date { get; set; }
        public List<CalendarEvent> Events { get; set; }
        public List<SingleTask> Tasks { get; set; }
        public List<RepeatedTaskEvent> TaskEvents { get; set; }
    }
}