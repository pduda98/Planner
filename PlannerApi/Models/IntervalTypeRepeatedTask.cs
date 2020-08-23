using PlannerApi.Enums;

namespace PlannerApi.Models
{
    public class RoutineTypeRepeatedTask : RepeatedTask
    {
        public RoutineTypeEnum IntervalType { get; set; }
    }
}