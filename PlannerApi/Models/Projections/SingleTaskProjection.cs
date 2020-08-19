using System.Collections.Generic;

namespace PlannerApi.Models.Projections
{
    public class SingleTaskProjection : SingleTask
    {
        public List<SingleTask> SubTasks {get; set; }
    }
}