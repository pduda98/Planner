using System;

namespace PlannerApi.Models
{
    public class RepeatedTask : Task
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}