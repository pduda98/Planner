using System;
using PlannerApi.Enums;

namespace PlannerApi.Models
{
    public class SingleTask : Task
    {
        public string SubtaskOf { get; set; }
        public DateTime Deadline { get; set; }
        public StatusEnum Status { get; set; }
    }
}