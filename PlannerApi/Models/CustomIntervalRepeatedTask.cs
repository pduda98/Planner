using System;
namespace PlannerApi.Models
{
    public class CustomIntervalRepeatedTask : RepeatedTask
    {
        public TimeSpan CustomInterval { get; set; }
    }
}