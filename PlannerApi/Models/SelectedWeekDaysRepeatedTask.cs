using System;

namespace PlannerApi.Models
{
    public class SelectedWeekDaysRepeatedTask : RepeatedTask
    {
        public DateTime Time { get; set; }
        public WeekDays WeekDays { get; set; }
    }
}