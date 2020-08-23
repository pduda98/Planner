using System.Collections.Generic;

namespace PlannerApi.Models.Projections
{
    public class RepeatedTaskProjection : RepeatedTask
    {
        public List<RepeatedTaskEvent> TaskEvents { get; set; }
    }
}